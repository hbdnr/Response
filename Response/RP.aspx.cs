using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class RP : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
         
        //Ekrana yazı yazdırma
        Response.Write("Halef Budanur");

        //Farklı bir html dosyasını yazdırma
        Response.WriteFile("Deneme.html");

        //Başka sayfaya yönlendirme 
        Response.Redirect("http://www.google.com");

        

        //Bu değer tampon bellekte tutulmadan ekrana yazdırılır.
        Response.Write("ilk değer");
        
        Response.Buffer = true;

        //Bu değer ise tampon bellekte tutulduktan sonra ekrana yazdırılır.
        Response.Write("ikinci değer");

        
        /*Flush kullanıldığında tampon bellek kullanıldığı için ilk açılışta biraz
        bekler ardından 1000 tane birden merhaba yazar sayfa yenilendiğinde tampon 
        bellek kullanıldığından dolayı kaldığı yerden devam eder.*/
        Response.Buffer = true;
        Response.Flush();
        for (int i = 0; i < 500000; i++)
        {
            Response.Write("Merhaba<br>");
        }
        
        

        Response.End();
        //bu yazılmaz çünkü end kullanıldı
        Response.Write("DENEME");

        //Tampon bellek başlatma
        Response.ExpiresAbsolute = DateTime.Now;
        //Tampon bellek sonlandırma
        Response.Expires = DateTime.Now.Day;


    }
}