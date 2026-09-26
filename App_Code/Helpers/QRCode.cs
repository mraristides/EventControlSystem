using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Drawing;
using System.Drawing.Imaging;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
using System.Configuration;
using System.IO;
using iTextSharp;

/// <summary>
/// Summary description for QRCode
/// </summary>
public class QRCode
{
    private Doc Doc = new Doc();
    private Where where = new Where();
    private QRCodeEncoder qrEncoder = new QRCodeEncoder();
    private string DomainIp = ConfigurationManager.ConnectionStrings["DomainIp"].ConnectionString;
    

    public iTextSharp.text.Image ImageQR(string ID)
    {
        string QRCodeUser = "http://" + DomainIp + "/Check?id=" + ID;
        Bitmap QRImage = qrEncoder.Encode(QRCodeUser);
        iTextSharp.text.Image pdfImage = iTextSharp.text.Image.GetInstance(QRImage, ImageFormat.Png);
        return pdfImage;

    }

    

}