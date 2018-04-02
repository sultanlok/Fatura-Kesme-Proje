using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;


using CrystalDecisions.Shared;

using CrystalDecisions.Windows.Forms;

using CrystalDecisions.ReportSource;
//ReportDocument sınıfına erişebilmek için aşağıdaki using kısmını
//projemize ekliyoruz.
namespace FATURA_PROJESİ
{
    public partial class Yazdır : Form
    {
        public Yazdır()
        {
            InitializeComponent();
            crGoster.ReportSource = "C:\\Users\\Samsung\\Documents\\Visual Studio 2012\\Projects\\FATURA PROJESİ\\FATURA PROJESİ\\FATURA PROJESİ.csproj\\crGoster.rpt";
        }

        private void crGoster_Load(object sender, EventArgs e)
        {

        }
        
        /*  SqlConnection baglanti = new SqlConnection("Data Source=SAMSUNGPC;Initial Catalog=faturaIslemleri;Integrated Security=true;");
        public void ParamAyarla(ParameterFieldDefinitions pfd, string pIsim, string pDeger)
         {
           /*  ParameterFieldDefinition crPFD;
             crPFD = pfd[pIsim]; //hangi parameter field’ı kullanacağımızı seçiyoruz
             ParameterValues crPDeger = crPFD.CurrentValues;
             ParameterDiscreteValue crPDV = new ParameterDiscreteValue();
             crPDV.Value = pDeger; //parametre olarak aldığımız değeri parameter field’e aktarıyoruz.
             crPDeger.Add(crPDV);
             crPFD.ApplyCurrentValues(crPDeger);
         }
        public static ParameterFields pfs;
        private void Yazdır_Load(object sender, EventArgs e)
        {
            pfs = new ParameterFields();

            ParameterField adı = new ParameterField();
            ParameterField soyı = new ParameterField();
            ParameterField unı = new ParameterField();
            ParameterField adresı = new ParameterField();
            ParameterField VDı = new ParameterField();
            ParameterField Vnoı = new ParameterField();

            ParameterDiscreteValue pdDeger1 = new ParameterDiscreteValue();
            ParameterDiscreteValue pdDeger2 = new ParameterDiscreteValue();
            ParameterDiscreteValue pdDeger3 = new ParameterDiscreteValue();
            ParameterDiscreteValue pdDeger4 = new ParameterDiscreteValue();
            ParameterDiscreteValue pdDeger5 = new ParameterDiscreteValue();
            ParameterDiscreteValue pdDeger6 = new ParameterDiscreteValue();
            pdDeger1.Value =FaturaForm.ad;//Parametreye vermek istediğiniz değer
            pdDeger2.Value =FaturaForm.soy; //Parametreye vermek istediğiniz değer
            pdDeger3.Value =FaturaForm.un; //Parametreye vermek istediğiniz değer
            pdDeger4.Value =FaturaForm.adres; //Parametreye vermek istediğiniz değer
            pdDeger5.Value =FaturaForm.VD;
            pdDeger6.Value =FaturaForm.Vno;

            adı.CurrentValues.Add(pdDeger1);
            soyı.CurrentValues.Add(pdDeger2);
            unı.CurrentValues.Add(pdDeger3);
            adresı.CurrentValues.Add(pdDeger4);
            VDı.CurrentValues.Add(pdDeger5);
            Vnoı.CurrentValues.Add(pdDeger6);

            pfs.Add(adı);
            pfs.Add(soyı);
            pfs.Add(unı);
            pfs.Add(adresı);
            pfs.Add(VDı);
            pfs.Add(Vnoı);
           
            //frm.form = this;
            MessageBox.Show("" + pfs);
            crGoster.ParameterFieldInfo = pfs;

           

         */
          
        }
       
    
    }

