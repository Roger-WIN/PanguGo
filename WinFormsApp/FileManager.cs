using System;
using System.IO;
using System.Linq;
using System.Text;

namespace WinFormsApp
{
    public class FileManager
    {
        /* 将文件读取为字节流 */
        public static byte[] FileToByteStream(string filePath)
        {
            var fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read); // 以读权限打开文件
            var fileBytes = new byte[fileStream.Length]; // 利用文件流的长度创建新的字节数组
            fileStream.Read(fileBytes, 0, fileBytes.Length); // 从文件流中读取字节块并写入字节流
            fileStream.Close(); // 关闭文件流
            return fileBytes;
        }

        /* 利用字节流创建或写入新文件 */
        public static void ByteStreamToFile(string filePath, byte[] fileBytes)
        {
            var fileStream = new FileStream(filePath, FileMode.OpenOrCreate, FileAccess.Write); // 以写权限打开或新建文件
            fileStream.Write(fileBytes, 0, fileBytes.Length); // 将字节流写入文件
            fileStream.Close(); // 关闭文件流
        }

        /* 判断产生该字节流的文件是否是文本文件 */
        public static bool IsTextFile(byte[] fileBytes)
        {
            var fileByteList = fileBytes.ToList(); // 利用字节数组创建字节列表
            return !fileByteList.Contains(0); // 若存在字节 0，则不是文本文件
        }

        /* 解析获取字节流的编码类型 */
        public static Encoding GetEncodingType(byte[] fileBytes)
        {
            if (IsUTF8WithoutBom(fileBytes))
                return new UTF8Encoding(); // 不带 BOM 的 UTF-8
            else if (fileBytes[0] == 0xEF && fileBytes[1] == 0xBB && fileBytes[2] == 0xBF)
                return Encoding.UTF8; // 带 BOM 的 UTF-8
            else if (fileBytes[0] == 0xFE && fileBytes[1] == 0xFF && fileBytes[2] == 0x00)
                return Encoding.BigEndianUnicode;
            else if (fileBytes[0] == 0xFF && fileBytes[1] == 0xFE && fileBytes[2] == 0x41)
                return Encoding.Unicode;
            else
                return Encoding.Default;
        }

        /* 判断是否是不带 BOM 的 UTF-8 编码 */
        private static bool IsUTF8WithoutBom(byte[] fileBytes)
        {
            var charByteCounter = 1;  // 计算当前分析的字符应还有的字节数 
            byte curByte; // 当前分析的字节
            foreach (var fileByte in fileBytes)
            {
                curByte = fileByte;
                if (charByteCounter == 1)
                {
                    if (curByte >= 0x80)
                    {
                        while (((curByte <<= 1) & 0x80) != 0) // 判断当前
                            charByteCounter++;
                        if (charByteCounter == 1 || charByteCounter > 6) // 标记位首位若为非 0，则至少以 2 个 1 开始，如：110XXXXX…………1111110X
                            return false;
                    }
                }
                else
                {
                    if ((curByte & 0xC0) != 0x80) // 若是 UTF-8，此时第一位必须为 1
                        return false;
                    charByteCounter--;
                }
            }
            if (charByteCounter > 1)
                throw new FormatException("非预期的 byte 格式！");
            return true;
        }
    }
}