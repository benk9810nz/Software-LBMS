using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    internal static class BookCoverFTP
    {
        public static string UploadBook(string fileName, string id)
        {
            // Create the Connection to the FTP Server
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://project.benking.co.nz/Books/" + id + ".jpg");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            // Login with the 'uploadBook' User
            request.Credentials = new NetworkCredential("uploadBook", "password123");

            // Copy the contents of the file to the request stream.
            byte[] fileContents = File.ReadAllBytes(fileName);
            request.ContentLength = fileContents.Length;

            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            response.Close();
            return "Sucess";
        }

        public static Bitmap DownloadBook(string id)
        {
            WebClient ftpClient = new WebClient();
            ftpClient.Credentials = new NetworkCredential("uploadBook", "password123");
            byte[] imageByte = ftpClient.DownloadData("ftp://project.benking.co.nz/Books/" + id + ".jpg");
            MemoryStream mStream = new MemoryStream();
            mStream.Write(imageByte, 0, Convert.ToInt32(imageByte.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}