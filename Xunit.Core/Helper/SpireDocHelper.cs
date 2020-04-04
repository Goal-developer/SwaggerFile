using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.StaticFiles;
using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace XUnit.Core.Helper
{
    public class SpireDocHelper
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        public SpireDocHelper(IWebHostEnvironment hostingEnvironment)
        {
            _hostingEnvironment = hostingEnvironment;
        }
        /// <summary>
        /// 静态页面转文件
        /// </summary>
        /// <param name="html">静态页面html</param>
        /// <param name="type">文件类型</param>
        /// <param name="contenttype">上下文类型</param>
        /// <returns></returns>
        public Stream SwaggerConversHtml(string html, string type, out string contenttype)
        {
            string fileName = Guid.NewGuid().ToString() + type;
            //文件存放路径
            string webRootPath = _hostingEnvironment.WebRootPath;
            string path = webRootPath + @"\Files\TempFiles\";
            var addrUrl = path + $"{fileName}";
            FileStream fileStream = null;
            var provider = new FileExtensionContentTypeProvider();
            contenttype = provider.Mappings[type];
            try
            {
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                var data = Encoding.Default.GetBytes(html);
                var stream = ByteHelper.BytesToStream(data);
                //创建Document实例
                Document document = new Document();
                //加载HTML文档
                document.LoadFromStream(stream, FileFormat.Html, XHTMLValidationType.None);
                //保存为Word
                document.SaveToFile(addrUrl, FileFormat.Docx);

                document.Close();
                fileStream = File.Open(addrUrl, FileMode.OpenOrCreate);
                var filedata = ByteHelper.StreamToBytes(fileStream);
                var outdata = ByteHelper.BytesToStream(filedata);

                return outdata;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
                if (File.Exists(addrUrl))
                    File.Delete(addrUrl);//删掉文件
            }
        }
    }
}
