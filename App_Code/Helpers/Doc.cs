using iTextSharp.text;
using System;
using System.Linq;
using System.Drawing;
using iTextSharp.text.pdf;
using System.IO;


/// <summary>
/// ///////////////////////////////////////////////
/// ///////// <!-- Code developed by Blind --> ////
/// ///////////////////// 我看你 ///////////////////
/// </summary>

/// <summary>
/// Summary description for Doc
/// </summary>
public class Doc
{
    private DataClassesDataContext Database = new DataClassesDataContext();
    private Command cmd;
    private Where where;
    private Season season;
    private FontFamily Arial;
    private BaseColor Black;
    private BaseColor White;

    public Doc()
    {
        Database = new DataClassesDataContext();
        cmd = new Command();
        where = new Where();
        season = new Season();
        Arial = new FontFamily("Arial");
        Black = new BaseColor(Color.Black);
        White = new BaseColor(Color.White);
    }

    public BaseColor Red()
    {
        Color red = ColorTranslator.FromHtml("#806000");
        BaseColor color = new BaseColor(red);
        return color;
    }

    public iTextSharp.text.Font TimesNewRoman()
    {
        BaseFont Times = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, false);
        iTextSharp.text.Font font = new iTextSharp.text.Font(Times, 55, iTextSharp.text.Font.ITALIC, Red());
        return font;
    }
    

    public iTextSharp.text.Font getFont(FontFamily FontFamily, float Size, BaseColor Color, bool Italic, bool Negrito)
    {
        iTextSharp.text.Font MyFont = FontFactory.GetFont(FontFamily.Name, Size, Color);
        if (Italic == true)
        {
            MyFont.SetStyle((int)FontStyle.Italic);
        }
        else if (Negrito == true)
        {
            MyFont.SetStyle((int)FontStyle.Bold);
        }
        return MyFont;

    } 

    
    public void Certificado(int SeasonID, string MapPath)
    {
        tb_season getSeason = season.getSeason(SeasonID);
        if (getSeason.Certificado == "CreaJR")
        {
            Certificado_CreaJr(getSeason, MapPath);
        }
        else if (getSeason.Certificado == "Semea")
        {
            Certificado_Semea(getSeason, MapPath);
        }
    }

    public void CertificadoUnico(tb_user tbUser, string MapPath)
    {
        tb_season getSeason = season.getSeason(Convert.ToInt32(tbUser.season_id));
        if (getSeason.Certificado == "CreaJR")
        {
            Certificado_CreaJrUnico(tbUser,getSeason, MapPath);
        }
        else if (getSeason.Certificado == "Semea")
        {
            Certificado_SemeaUnico(tbUser, getSeason, MapPath);
        }
    }

    public void Crachar(int SeasonID, string MapPath)
    {
        tb_season getSeason = season.getSeason(SeasonID);
        if (getSeason.Certificado == "CreaJR")
        {
            Crachar_CreaJr(getSeason, MapPath);
        }
        else if (getSeason.Certificado == "Semea")
        {
            Crachar_Semea(getSeason, MapPath);
        }
    }

    public void CracharUnico(tb_user user, string MapPath)
    {
        tb_season getSeason = season.getSeason(Convert.ToInt32(user.season_id));
        if (getSeason.Certificado == "CreaJR")
        {
            Crachar_CreaJrUnico(user, getSeason, MapPath);
        }
        else if (getSeason.Certificado == "Semea")
        {
            Crachar_SemeaUnico(user, getSeason, MapPath);
        }
    }


    private void CreateDirectory(string Directory)
    {
        FileInfo File = new FileInfo(Directory);
        if (!File.Directory.Exists)
        {
            File.Directory.Create();
        }
    }


    public void Certificado_Semea(tb_season tbSeason, string MapPath)
    {
        string Directory = where.FolderSeason(Convert.ToString(tbSeason.ID)) + "Certificados.pdf";
        CreateDirectory(Directory);
        if (File.Exists(Directory))
        {
            File.Delete(Directory);
        }

        Document document = new Document(PageSize.A4.Rotate(), 20, 20, 170, 0);
        document.AddCreationDate();
        PdfWriter Writer = PdfWriter.GetInstance(document, new FileStream(Directory, FileMode.Create));


        string PathImg = MapPath + "semea\\";


        // Logo Left
        iTextSharp.text.Image LogoSemea = iTextSharp.text.Image.GetInstance(PathImg + "semealeft.png");
        LogoSemea.ScaleToFit(480, 250);
        LogoSemea.SetAbsolutePosition(-60, 445);

        // Image Right
        iTextSharp.text.Image ImageRight = iTextSharp.text.Image.GetInstance(PathImg + "semearight.png");
        ImageRight.ScaleToFit(450, 225);
        ImageRight.SetAbsolutePosition(600, 390);

        // Image Right
        iTextSharp.text.Image InfoSemea = iTextSharp.text.Image.GetInstance(PathImg + "infosemea.png");
        InfoSemea.ScaleToFit(320, 320);
        InfoSemea.Alignment = Element.ALIGN_CENTER;

        // Certificado
        string StringCertificado = "CERTIFICADO";
        Paragraph CertificadoString = new Paragraph(StringCertificado, TimesNewRoman());
        CertificadoString.Alignment = Element.ALIGN_CENTER;
        CertificadoString.SpacingBefore = -25;

        // Certificamos
        string StringCertificamos = "O Crea-Minas Júnior Núcleo Governador Valadares certifica que:";
        Paragraph CertificamosString = new Paragraph(StringCertificamos, getFont(Arial, 12, Black, false, true));
        CertificamosString.Alignment = Element.ALIGN_CENTER;
        CertificamosString.SpacingAfter = 20;

        // Barra Preta
        iTextSharp.text.Image BarraPreta = iTextSharp.text.Image.GetInstance(PathImg + "BarraPreta.png");
        BarraPreta.ScaleToFit(750, 4);
        BarraPreta.Alignment = Element.ALIGN_CENTER;

        // Assinatura Bot Right
        iTextSharp.text.Image LogoRight = iTextSharp.text.Image.GetInstance(PathImg + "assTalita.png");
        LogoRight.ScaleToFit(280, 140);
        LogoRight.SetAbsolutePosition(555, 40);

        // Assinatura Bot Middle
        iTextSharp.text.Image LogoCrea = iTextSharp.text.Image.GetInstance(PathImg + "crealogo.png");
        LogoCrea.ScaleToFit(220, 240);
        LogoCrea.SetAbsolutePosition(310, 45);

        // Assinatura Bot Left
        iTextSharp.text.Image LogoLeft = iTextSharp.text.Image.GetInstance(PathImg + "assSarah.png");
        LogoLeft.ScaleToFit(280, 140);
        LogoLeft.SetAbsolutePosition(10, 40);

        try
        {
            document.Open();
            var users = from x in Database.tb_users where x.season_id.Equals(tbSeason.ID) select x;
            foreach (var user in users)
            {
                document.NewPage();
                document.Add(LogoSemea);
                document.Add(ImageRight);
                document.Add(CertificadoString);
                document.Add(CertificamosString);

                // User Nome
                Paragraph UserNome = new Paragraph(user.nome.ToUpper(), getFont(new FontFamily("Calibri"), 32, Black, false, true));
                UserNome.Alignment = Element.ALIGN_CENTER;
                UserNome.SpacingBefore = 15;
                UserNome.SpacingAfter = -12;
                document.Add(UserNome);

                document.Add(BarraPreta);
                string datastring = tbSeason.Data;
                string SeasonName = Convert.ToString(tbSeason.Nome);
                string RG = cmd.FormatRG(Convert.ToString(user.rg));
                string StringContent = "Portador do RG " + RG + " participou do " + SeasonName + " (Seminário de Engenharia e Agronomia) promovido pelo Crea-Minas Júnior - Núcleo Governador Valadares, " + datastring + ", totalizando " + Convert.ToString(user.horas_total) + " horas.";
                Paragraph Content = new Paragraph(StringContent, getFont(Arial, 13, Black, false, false));
                Content.IndentationLeft = 30;
                Content.IndentationRight = 30;
                Content.SpacingAfter = 10;
                Content.Alignment = Element.ALIGN_CENTER;

                document.Add(Content);

                document.Add(LogoRight);
                document.Add(LogoCrea);
                document.Add(LogoLeft);
            }
            document.Close();
        }
        catch (Exception)
        {

        }
    }

    public void Certificado_SemeaUnico(tb_user tbUser, tb_season tbSeason, string MapPath)
    {
        string Directory = where.FolderSeasonUsers(Convert.ToString(tbSeason.ID)) + "Certificado_" + tbUser.nome.Replace(" ", "") +".pdf";
        CreateDirectory(Directory);
        if (File.Exists(Directory))
        {
            File.Delete(Directory);
        }

        Document document = new Document(PageSize.A4.Rotate(), 20, 20, 170, 0);
        document.AddCreationDate();
        PdfWriter Writer = PdfWriter.GetInstance(document, new FileStream(Directory, FileMode.Create));


        string PathImg = MapPath + "semea\\";


        // Logo Left
        iTextSharp.text.Image LogoSemea = iTextSharp.text.Image.GetInstance(PathImg + "semealeft.png");
        LogoSemea.ScaleToFit(480, 250);
        LogoSemea.SetAbsolutePosition(-60, 445);

        // Image Right
        iTextSharp.text.Image ImageRight = iTextSharp.text.Image.GetInstance(PathImg + "semearight.png");
        ImageRight.ScaleToFit(450, 225);
        ImageRight.SetAbsolutePosition(600, 390);

        // Image Right
        iTextSharp.text.Image InfoSemea = iTextSharp.text.Image.GetInstance(PathImg + "infosemea.png");
        InfoSemea.ScaleToFit(320, 320);
        InfoSemea.Alignment = Element.ALIGN_CENTER;

        // Certificado
        string StringCertificado = "CERTIFICADO";
        Paragraph CertificadoString = new Paragraph(StringCertificado, TimesNewRoman());
        CertificadoString.Alignment = Element.ALIGN_CENTER;
        CertificadoString.SpacingBefore = -25;

        // Certificamos
        string StringCertificamos = "O Crea-Minas Júnior Núcleo Governador Valadares certifica que:";
        Paragraph CertificamosString = new Paragraph(StringCertificamos, getFont(Arial, 12, Black, false, true));
        CertificamosString.Alignment = Element.ALIGN_CENTER;
        CertificamosString.SpacingAfter = 20;

        // Barra Preta
        iTextSharp.text.Image BarraPreta = iTextSharp.text.Image.GetInstance(PathImg + "BarraPreta.png");
        BarraPreta.ScaleToFit(750, 4);
        BarraPreta.Alignment = Element.ALIGN_CENTER;

        // Assinatura Bot Right
        iTextSharp.text.Image LogoRight = iTextSharp.text.Image.GetInstance(PathImg + "assTalita.png");
        LogoRight.ScaleToFit(280, 140);
        LogoRight.SetAbsolutePosition(555, 40);

        // Assinatura Bot Middle
        iTextSharp.text.Image LogoCrea = iTextSharp.text.Image.GetInstance(PathImg + "crealogo.png");
        LogoCrea.ScaleToFit(220, 240);
        LogoCrea.SetAbsolutePosition(310, 45);

        // Assinatura Bot Left
        iTextSharp.text.Image LogoLeft = iTextSharp.text.Image.GetInstance(PathImg + "assSarah.png");
        LogoLeft.ScaleToFit(280, 140);
        LogoLeft.SetAbsolutePosition(10, 40);

        try
        {
            document.Open();
            document.NewPage();
            document.Add(LogoSemea);
            document.Add(ImageRight);
            document.Add(CertificadoString);
            document.Add(CertificamosString);

            // User Nome
            Paragraph UserNome = new Paragraph(tbUser.nome.ToUpper(), getFont(new FontFamily("Calibri"), 32, Black, false, true));
            UserNome.Alignment = Element.ALIGN_CENTER;
            UserNome.SpacingBefore = 15;
            UserNome.SpacingAfter = -12;
            document.Add(UserNome);

            document.Add(BarraPreta);
            string datastring = tbSeason.Data;
            string SeasonName = Convert.ToString(tbSeason.Nome);
            string RG = cmd.FormatRG(Convert.ToString(tbUser.rg));
            string StringContent = "Portador do RG " + RG + " participou do " + SeasonName + " (Seminário de Engenharia e Agronomia) promovido pelo Crea-Minas Júnior - Núcleo Governador Valadares, " + datastring + ", totalizando " + Convert.ToString(tbUser.horas_total) + " horas.";
            Paragraph Content = new Paragraph(StringContent, getFont(Arial, 13, Black, false, false));
            Content.IndentationLeft = 30;
            Content.IndentationRight = 30;
            Content.SpacingAfter = 10;
            Content.Alignment = Element.ALIGN_CENTER;

            document.Add(Content);

            document.Add(LogoRight);
            document.Add(LogoCrea);
            document.Add(LogoLeft);
            document.Close();
        }
        catch (Exception)
        {

        }
    }

    public void Certificado_CreaJr(tb_season tbSeason, string MapPath)
    {
        string Directory = where.FolderSeason(Convert.ToString(tbSeason.ID)) + "Certificados.pdf";
        CreateDirectory(Directory);
        if (File.Exists(Directory))
        {
            File.Delete(Directory);
        }

        Document document = new Document(PageSize.A4.Rotate(), 30, 30, 0, 0);
        document.AddCreationDate();
        PdfWriter Writer = PdfWriter.GetInstance(document, new FileStream(Directory, FileMode.Create));


        string PathImg = MapPath + "creajr\\";


        // Logo
        iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance(PathImg + "crealogo.png");
        Logo.ScaleToFit(300, 125);
        Logo.SetAbsolutePosition(520, 500);

        // Logo Bot Right
        iTextSharp.text.Image LogoRight = iTextSharp.text.Image.GetInstance(PathImg + "crea.png");
        LogoRight.ScaleToFit(300, 125);
        LogoRight.SetAbsolutePosition(520, 20);

        // Assinatura Bot Middle
        iTextSharp.text.Image LogoMiddle = iTextSharp.text.Image.GetInstance(PathImg + "assTalita.png");
        LogoMiddle.ScaleToFit(200, 125);
        LogoMiddle.SetAbsolutePosition(260, 20);

        // Assinatura Bot Left
        iTextSharp.text.Image LogoLeft = iTextSharp.text.Image.GetInstance(PathImg + "assSarah.png");
        LogoLeft.ScaleToFit(120, 80);
        LogoLeft.SetAbsolutePosition(100, 23);

        // Certificado
        string StringCertificado = "CERTIFICADO";
        Paragraph CertificadoString = new Paragraph(StringCertificado, getFont(Arial, 44, Black, false, true));
        CertificadoString.Alignment = Element.ALIGN_LEFT;
        CertificadoString.IndentationLeft = 130;
        CertificadoString.SpacingBefore = 80;


        string SeasonName = Convert.ToString(tbSeason.Nome);
        Paragraph SeasonNome = new Paragraph(SeasonName, getFont(Arial, 44, White, false, true));
        SeasonNome.Alignment = Element.ALIGN_LEFT;
        SeasonNome.IndentationLeft = 200;
        SeasonNome.SpacingBefore = 35;

        // Tarja
        iTextSharp.text.Image Tarja = iTextSharp.text.Image.GetInstance(PathImg + "tarja.png");
        Tarja.SetAbsolutePosition(0, 325);
        Tarja.ScaleToFit(850, 100);



        string StringCert = "Certificamos que ";
        Paragraph Certificamos = new Paragraph(StringCert, getFont(Arial, 18, Black, false, true));
        Certificamos.Alignment = Element.ALIGN_LEFT;
        Certificamos.IndentationLeft = 20;
        Certificamos.SpacingBefore = 30;

        try
        {
            document.Open();
            var users = from x in Database.tb_users where x.season_id.Equals(tbSeason.ID) orderby x.nome select x;
            foreach (var user in users)
            {
                if (!user.nome.Contains("Participante"))
                {
                    document.NewPage();
                    document.Add(Logo);
                    document.Add(CertificadoString);
                    document.Add(Tarja);
                    document.Add(SeasonNome);
                    document.Add(Certificamos);

                    // User Nome
                    Paragraph UserNome = new Paragraph(user.nome, getFont(Arial, 24, Black, false, true));
                    UserNome.Alignment = Element.ALIGN_LEFT;
                    UserNome.IndentationLeft = 160;
                    UserNome.SpacingAfter = 10;
                    document.Add(UserNome);


                    string datastring = tbSeason.Data;
                    string RG = user.rg.ToUpper();
                    string StringContent = "Portador do RG " + RG + ", participou do " + SeasonName + ", realizado pelo Crea-Minas Júnior núcleo Governador Valadares, " + datastring + ".";
                    Paragraph Content = new Paragraph(StringContent, getFont(Arial, 18, Black, false, false));
                    Content.IndentationLeft = 70;
                    Content.SpacingAfter = 10;

                    document.Add(Content);

                    string StringHoras = "Carga Horária: " + Convert.ToString(user.horas_total) + " Horas";
                    Paragraph Horas = new Paragraph(StringHoras, getFont(Arial, 14, Black, false, false));
                    Horas.IndentationLeft = 20;
                    document.Add(Horas);
                    document.Add(LogoRight);
                    document.Add(LogoMiddle);
                    document.Add(LogoLeft);
                }
            }
            document.Close();
        }
        catch (Exception)
        {

        }
    }


    public void Certificado_CreaJrUnico(tb_user tbUser,tb_season tbSeason, string MapPath)
    {
        string Directory = where.FolderSeasonUsers(Convert.ToString(tbSeason.ID)) + "Certificado_"+tbUser.nome.Replace(" ", "")+".pdf";
        CreateDirectory(Directory);
        if (File.Exists(Directory))
        {
            File.Delete(Directory);
        }

        Document document = new Document(PageSize.A4.Rotate(), 30, 30, 0, 0);
        document.AddCreationDate();
        PdfWriter Writer = PdfWriter.GetInstance(document, new FileStream(Directory, FileMode.Create));


        string PathImg = MapPath + "creajr\\";


        // Logo
        iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance(PathImg + "crealogo.png");
        Logo.ScaleToFit(300, 125);
        Logo.SetAbsolutePosition(520, 500);

        // Logo Bot Right
        iTextSharp.text.Image LogoRight = iTextSharp.text.Image.GetInstance(PathImg + "crea.png");
        LogoRight.ScaleToFit(300, 125);
        LogoRight.SetAbsolutePosition(520, 20);

        // Assinatura Bot Middle
        iTextSharp.text.Image LogoMiddle = iTextSharp.text.Image.GetInstance(PathImg + "assTalita.png");
        LogoMiddle.ScaleToFit(200, 125);
        LogoMiddle.SetAbsolutePosition(260, 20);

        // Assinatura Bot Left
        iTextSharp.text.Image LogoLeft = iTextSharp.text.Image.GetInstance(PathImg + "assSarah.png");
        LogoLeft.ScaleToFit(120, 80);
        LogoLeft.SetAbsolutePosition(100, 23);

        // Certificado
        string StringCertificado = "CERTIFICADO";
        Paragraph CertificadoString = new Paragraph(StringCertificado, getFont(Arial, 44, Black, false, true));
        CertificadoString.Alignment = Element.ALIGN_LEFT;
        CertificadoString.IndentationLeft = 130;
        CertificadoString.SpacingBefore = 80;


        string SeasonName = Convert.ToString(tbSeason.Nome);
        Paragraph SeasonNome = new Paragraph(SeasonName, getFont(Arial, 44, White, false, true));
        SeasonNome.Alignment = Element.ALIGN_LEFT;
        SeasonNome.IndentationLeft = 200;
        SeasonNome.SpacingBefore = 35;

        // Tarja
        iTextSharp.text.Image Tarja = iTextSharp.text.Image.GetInstance(PathImg + "tarja.png");
        Tarja.SetAbsolutePosition(0, 325);
        Tarja.ScaleToFit(850, 100);



        string StringCert = "Certificamos que ";
        Paragraph Certificamos = new Paragraph(StringCert, getFont(Arial, 18, Black, false, true));
        Certificamos.Alignment = Element.ALIGN_LEFT;
        Certificamos.IndentationLeft = 20;
        Certificamos.SpacingBefore = 30;

        try
        {
            document.Open();
            document.NewPage();
            document.Add(Logo);
            document.Add(CertificadoString);
            document.Add(Tarja);
            document.Add(SeasonNome);
            document.Add(Certificamos);

            // User Nome
            Paragraph UserNome = new Paragraph(tbUser.nome, getFont(Arial, 24, Black, false, true));
            UserNome.Alignment = Element.ALIGN_LEFT;
            UserNome.IndentationLeft = 160;
            UserNome.SpacingAfter = 10;
            document.Add(UserNome);


            string datastring = tbSeason.Data;
            string RG = cmd.FormatRG(Convert.ToString(tbUser.rg));
            string StringContent = "Portador do RG " + RG + ", participou do " + SeasonName + ", realizado pelo Crea-Minas Júnior núcleo Governador Valadares, " + datastring + ".";
            Paragraph Content = new Paragraph(StringContent, getFont(Arial, 18, Black, false, false));
            Content.IndentationLeft = 70;
            Content.SpacingAfter = 10;

            document.Add(Content);

            string StringHoras = "Carga Horária: " + Convert.ToString(tbUser.horas_total) + " Horas";
            Paragraph Horas = new Paragraph(StringHoras, getFont(Arial, 14, Black, false, false));
            Horas.IndentationLeft = 20;
            document.Add(Horas);
            document.Add(LogoRight);
            document.Add(LogoMiddle);
            document.Add(LogoLeft);
            document.Close();
        }
        catch (Exception)
        {

        }
    }


    public void Crachar_Semea(tb_season tbSeason, string MapPath)
    {
        string Directory = where.FolderSeason(Convert.ToString(tbSeason.ID)) + "Crachas.pdf";
        CreateDirectory(Directory);
        if (File.Exists(Directory))
        {
            File.Delete(Directory);
        }

        string PathImg = MapPath + "semea\\";

        Document document = new Document(PageSize.A6, 0, 0, 130, 10);
        document.AddCreationDate();
        PdfWriter Writer = PdfWriter.GetInstance(document, new FileStream(Directory, FileMode.Create));


        // Logo Left
        iTextSharp.text.Image LogoSemea = iTextSharp.text.Image.GetInstance(PathImg + "semealeft.png");
        LogoSemea.ScaleToFit(215, 150);
        LogoSemea.SetAbsolutePosition(-40, 340);

        // Image Right
        iTextSharp.text.Image ImageRight = iTextSharp.text.Image.GetInstance(PathImg + "semearight.png");
        ImageRight.ScaleToFit(255, 140);
        ImageRight.SetAbsolutePosition(150, 320);

        // Logo CreaJR
        iTextSharp.text.Image LogoCreaJR = iTextSharp.text.Image.GetInstance(PathImg + "crealogo.png");
        LogoCreaJR.ScaleToFit(120, 80);
        LogoCreaJR.SetAbsolutePosition(15, 20);

        // Logo Crea
        iTextSharp.text.Image LogoCrea = iTextSharp.text.Image.GetInstance(PathImg + "crea.png");
        LogoCrea.ScaleToFit(120, 80);
        LogoCrea.SetAbsolutePosition(160, 20);


        try
        {
            document.Open();
            var users = from x in Database.tb_users where x.season_id.Equals(tbSeason.ID) select x;
            foreach (var user in users)
            {
                document.NewPage();

                document.Add(LogoSemea);
                document.Add(ImageRight);


                QRCode qrcode = new QRCode();
                iTextSharp.text.Image QRCodeImage = qrcode.ImageQR(Convert.ToString(user.id));
                QRCodeImage.Alignment = Element.ALIGN_CENTER;
                document.Add(QRCodeImage);

                // User Nome
                Paragraph UserNome = new Paragraph(user.nome, getFont(Arial, 23, Black, false, false));
                UserNome.Alignment = Element.ALIGN_CENTER;
                UserNome.SpacingBefore = 20;
                document.Add(UserNome);


                document.Add(LogoCreaJR);
                document.Add(LogoCrea);
            }
            document.Close();
        }
        catch (Exception)
        {

        }
    }

    public void Crachar_SemeaUnico(tb_user tbUser,tb_season tb_season, string MapPath)
    {
        string Directory = where.FolderSeasonUsers(Convert.ToString(tbUser.season_id)) + "Crachar_"+tbUser.nome.Replace(" ","")+".pdf";
        CreateDirectory(Directory);
        if (File.Exists(Directory))
        {
            File.Delete(Directory);
        }

        string PathImg = MapPath + "semea\\";

        Document document = new Document(PageSize.A6, 0, 0, 130, 10);
        document.AddCreationDate();
        PdfWriter Writer = PdfWriter.GetInstance(document, new FileStream(Directory, FileMode.Create));


        // Logo Left
        iTextSharp.text.Image LogoSemea = iTextSharp.text.Image.GetInstance(PathImg + "semealeft.png");
        LogoSemea.ScaleToFit(215, 150);
        LogoSemea.SetAbsolutePosition(-40, 340);

        // Image Right
        iTextSharp.text.Image ImageRight = iTextSharp.text.Image.GetInstance(PathImg + "semearight.png");
        ImageRight.ScaleToFit(255, 140);
        ImageRight.SetAbsolutePosition(150, 320);

        // Logo CreaJR
        iTextSharp.text.Image LogoCreaJR = iTextSharp.text.Image.GetInstance(PathImg + "crealogo.png");
        LogoCreaJR.ScaleToFit(120, 80);
        LogoCreaJR.SetAbsolutePosition(15, 20);

        // Logo Crea
        iTextSharp.text.Image LogoCrea = iTextSharp.text.Image.GetInstance(PathImg + "crea.png");
        LogoCrea.ScaleToFit(120, 80);
        LogoCrea.SetAbsolutePosition(160, 20);


        try
        {
            document.Open();            
            document.NewPage();

            document.Add(LogoSemea);
            document.Add(ImageRight);

            QRCode qrcode = new QRCode();
            iTextSharp.text.Image QRCodeImage = qrcode.ImageQR(Convert.ToString(tbUser.id));
            QRCodeImage.Alignment = Element.ALIGN_CENTER;
            document.Add(QRCodeImage);

            // User Nome
            Paragraph UserNome = new Paragraph(tbUser.nome, getFont(Arial, 23, Black, false, false));
            UserNome.Alignment = Element.ALIGN_CENTER;
            UserNome.SpacingBefore = 20;
            document.Add(UserNome);


            document.Add(LogoCreaJR);
            document.Add(LogoCrea);
            document.Close();
        }
        catch (Exception)
        {

        }
    }

    public void Crachar_CreaJr(tb_season tbSeason, string MapPath)
    {
        string Directory = where.FolderSeason(Convert.ToString(tbSeason.ID)) + "Crachas.pdf";
        CreateDirectory(Directory);
        if (File.Exists(Directory))
        {
            File.Delete(Directory);
        }

        string PathImg = MapPath + "creajr\\";

        Document document = new Document(PageSize.A6, 0, 0, 10, 10);
        document.AddCreationDate();
        PdfWriter Writer = PdfWriter.GetInstance(document, new FileStream(Directory, FileMode.Create));


        // Logo
        iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance(PathImg + "crealogo.png");
        Logo.Alignment = Element.ALIGN_CENTER;
        Logo.ScaleToFit(280, 150);

        string SeasonName = Convert.ToString(tbSeason.Nome);
        Paragraph SeasonNome = new Paragraph(SeasonName, getFont(Arial, 30, Black, false, true));
        SeasonNome.Alignment = Element.ALIGN_CENTER;
        SeasonNome.SpacingAfter = 30;



        try
        {
            document.Open();
            var users = from x in Database.tb_users where x.season_id.Equals(tbSeason.ID) select x;
            foreach (var user in users)
            {
                document.NewPage();

                document.Add(Logo);
                document.Add(SeasonNome);


                QRCode qrcode = new QRCode();
                iTextSharp.text.Image QRCodeImage = qrcode.ImageQR(Convert.ToString(user.id));
                QRCodeImage.Alignment = Element.ALIGN_CENTER;
                document.Add(QRCodeImage);

                // User Nome
                Paragraph UserNome = new Paragraph(user.nome, getFont(Arial, 25, Black, false, false));
                UserNome.Alignment = Element.ALIGN_CENTER;
                UserNome.SpacingBefore = 20;
                document.Add(UserNome);

            }
            document.Close();
        }
        catch (Exception)
        {

        }
    }


    public void Crachar_CreaJrUnico(tb_user tbUser, tb_season tbSeason, string MapPath)
    {
        string Directory = where.FolderSeasonUsers(Convert.ToString(tbUser.season_id)) + "Crachar_" +  tbUser.nome.Replace(" ", "") + ".pdf";
        CreateDirectory(Directory);
        if (File.Exists(Directory))
        {
            File.Delete(Directory);
        }
        string PathImg = MapPath + "creajr\\";

        Document document = new Document(PageSize.A6, 0, 0, 10, 10);
        document.AddCreationDate();
        PdfWriter Writer = PdfWriter.GetInstance(document, new FileStream(Directory, FileMode.Create));


        // Logo
        iTextSharp.text.Image Logo = iTextSharp.text.Image.GetInstance(PathImg + "crealogo.png");
        Logo.Alignment = Element.ALIGN_CENTER;
        Logo.ScaleToFit(280, 150);

        string SeasonName = Convert.ToString(tbSeason.Nome);
        Paragraph SeasonNome = new Paragraph(SeasonName, getFont(Arial, 30, Black, false, true));
        SeasonNome.Alignment = Element.ALIGN_CENTER;
        SeasonNome.SpacingAfter = 30;



        try
        {
            document.Open();
            document.NewPage();

            document.Add(Logo);
            document.Add(SeasonNome);


            QRCode qrcode = new QRCode();
            iTextSharp.text.Image QRCodeImage = qrcode.ImageQR(Convert.ToString(tbUser.id));
            QRCodeImage.Alignment = Element.ALIGN_CENTER;
            document.Add(QRCodeImage);

            // User Nome
            Paragraph UserNome = new Paragraph(tbUser.nome, getFont(Arial, 25, Black, false, false));
            UserNome.Alignment = Element.ALIGN_CENTER;
            UserNome.SpacingBefore = 20;
            document.Add(UserNome);
            
            document.Close();
        }
        catch (Exception)
        {

        }
    }
}