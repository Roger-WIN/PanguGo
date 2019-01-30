﻿using System;
using System.Collections.Generic;
using System.IO;

namespace WinFormsApp
{
    public class PanguService
    {
        private readonly string pathToUploadedFiles;
        private readonly string pathToConvertedFiles;

        public PanguService()
        {
            pathToUploadedFiles = "Files/Uploaded/"; // 指定上传的文件在服务中保存的目录
            pathToConvertedFiles = "Files/Converted/"; // 指定转换后的文件在服务中保存的目录

            if (!Directory.Exists(pathToUploadedFiles)) // 若上传的文件在服务中保存的目录不存在
                Directory.CreateDirectory(pathToUploadedFiles); // 则创建
            if (!Directory.Exists(pathToConvertedFiles)) // 若转换后的文件在服务中保存的目录不存在
                Directory.CreateDirectory(pathToConvertedFiles); // 则创建
        }

        /* 发送待转换文本，返回转换后的文本 */
        public string SpacingText(string text)
        {
            if (string.IsNullOrWhiteSpace(text)) // 源文本为空
                throw new ArgumentNullException("文本为空");
            else
                return Pangu.SpacingText(text);
        }

        /* 上传文件，返回这些文件在服务上保存的路径 */
        public string[] UploadFiles(string[] filePaths)
        {
            var uploadedFilePaths = new List<string>(filePaths.Length);
            foreach (var filePath in filePaths)
                uploadedFilePaths.Add(UploadFile(filePath));
            return (uploadedFilePaths.Count > 0) ? uploadedFilePaths.ToArray() : null; // 若至少有一个文件上传成功，返回其在服务上保存的路径；否则返回空
        }

        public string UploadFile(string filePath)
        {
            try
            {
                var fileBytes = FileManager.FileToByteStream(filePath); // 将文件读取为字节流
                var fileName = Path.GetFileName(filePath); // 获取文件名
                var uploadedFilePath = Path.Combine(pathToUploadedFiles, fileName); // 指定上传的文件在服务中保存的路径
                FileManager.ByteStreamToFile(uploadedFilePath, fileBytes); // 在服务的指定路径创建相同的文件
                return uploadedFilePath;
            }
            catch (ArgumentNullException) // 未选取文件
            {
                throw new ArgumentNullException("未选取文件");
            }
            catch (ArgumentException) // 选取无效
            {
                throw new ArgumentException("选取无效");
            }
            catch (FileNotFoundException) // 未找到该文件
            {
                throw new FileNotFoundException("未找到文件");
            }
        }

        /* 上传文件夹，返回其中的文件在服务上保存的路径。若为空目录，返回空 */
        public string[] UploadFolder(string folderPath)
        {
            if (!Directory.Exists(folderPath)) // 目录不存在
                throw new DirectoryNotFoundException("未找到该目录");

            var theFolder = new DirectoryInfo(folderPath); // 定位到选取的文件夹
            var theFiles = theFolder.GetFiles(); // 获取该目录下的所有文件
            if (theFiles.Length <= 0) // 该目录为空
                throw new IOException("目录为空");

            var filePaths = new List<string>(theFiles.Length); // 创建文件路径列表
            foreach (var file in theFiles)
                filePaths.Add(file.FullName); // 将该目录下的所有文件添加到文件路径列表
            return UploadFiles(filePaths.ToArray()); // 将该目录下的所有文件上传
        }

        /* 转换指定路径的文件，并返回转换后的文件保存在服务上的路径 */
        public string[] SpacingFiles(string[] filePaths, bool overrideFlag)
        {
            var convertedFilePaths = new List<string>(filePaths.Length);
            foreach (var filePath in filePaths)
                convertedFilePaths.Add(SpacingFile(filePath, overrideFlag));
            return (convertedFilePaths.Count > 0) ? convertedFilePaths.ToArray() : null; // 若至少有一个文件转换成功，返回转换后的文件保存在服务上的路径；否则返回空
        }

        public string SpacingFile(string filePath, bool overrideFlag)
        {
            try
            {
                var fileName = Path.GetFileName(filePath); // 获取原文件的文件名（包含扩展名）
                var originalFileBytes = FileManager.FileToByteStream(filePath); // 将文件读取为字节流
                var targetFileBytes = Pangu.SpacingByteStream(originalFileBytes); // 转换字节流
                if (!overrideFlag) // 不覆盖原文件
                {
                    var suffix = " - [Paranoid]"; // 指定目标文件名中的后缀
                    var extension = Path.GetExtension(filePath); // 获取原文件的扩展名
                    fileName = Path.GetFileNameWithoutExtension(filePath); // 获取原文件的文件名（不包含扩展名）
                    fileName += suffix; // 向目标文件名中添加后缀
                    fileName += extension; // 向目标文件名补齐扩展名
                }
                var convertedFilePath = Path.Combine(pathToConvertedFiles, fileName); // 指定转换后的文件在服务中保存的路径
                FileManager.ByteStreamToFile(convertedFilePath, targetFileBytes); // 在服务的指定路径创建目标文件
                return convertedFilePath;
            }
            catch (ArgumentNullException) // 文件路径为空
            {
                throw new ArgumentNullException("文件路径为空");
            }
            catch (ArgumentException) // 文件路径无效
            {
                throw new ArgumentException("文件路径无效");
            }
            catch (FileNotFoundException) // 未找到文件
            {
                throw new FileNotFoundException("未找到文件");
            }
            catch (FormatException) // 该文件不是文本文件
            {
                throw new FormatException("文件「" + Path.GetFileName(filePath) + "」不是文本文件，不可转换");
            }
        }

        /* 从服务上的指定路径下载文件 */
        public void DownLoadFiles(string[] filePaths, string downloadPath)
        {
            foreach (var originalFilePath in filePaths)
                DownLoadFile(originalFilePath, downloadPath);
        }

        public void DownLoadFile(string filePath, string downloadPath)
        {
            if (!Directory.Exists(downloadPath))
                throw new DirectoryNotFoundException("未找到该目录");

            try
            {
                var fileName = Path.GetFileName(filePath);
                var targetFilePath = Path.Combine(downloadPath, fileName);
                FileManager.ByteStreamToFile(targetFilePath, FileManager.FileToByteStream(filePath));
            }
            catch (ArgumentNullException) // 文件路径为空
            {
                throw new ArgumentNullException("文件路径为空");
            }
            catch (ArgumentException) // 文件路径无效
            {
                throw new ArgumentException("文件路径无效");
            }
            catch (FileNotFoundException) // 未找到文件
            {
                throw new FileNotFoundException("未找到文件");
            }
        }

        /* 清除缓存文件 */
        public void ClearFiles()
        {
            var filesDir = new DirectoryInfo("Files/"); // 指定缓存文件夹的路径
            if (Directory.Exists(filesDir.FullName)) // 若该缓存文件夹存在（未被意外删除）
                filesDir.Delete(true); // 删除缓存文件夹（包含子目录和文件）
        }
    }
}