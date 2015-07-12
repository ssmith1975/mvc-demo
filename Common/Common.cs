using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    #region Enumerations
    public enum ImageType
    {
        jpeg,
        png,
        gif

    }
    #endregion
    #region Classes
    public partial class Common
    {
        /// <summary>
        /// Conerts  a binary field in SQL into a base64 source path
        /// </summary>
        /// <param name="photo">Array of bytes</param>
        /// <param name="fileType">Image type (jpeg, png, gif), defaults to png</param>
        /// <returns></returns>
        static public string GetImageSource(byte[] photo, ImageType fileType = ImageType.png)
        {
            string imageSrc = String.Empty;

            using (System.IO.MemoryStream ms = new System.IO.MemoryStream())
            {
                
                if (photo != null)
                {
                    ms.Write(photo, 78, photo.Length - 78); // strip out 78 byte OLE header (don't need to do this for normal images)
                    string imageBase64 = Convert.ToBase64String(ms.ToArray());
                    imageSrc = string.Format("data:image/{0};base64,{1}", fileType, imageBase64);
                }


            } // end using

            return imageSrc;
        }
    }
    #endregion
}
