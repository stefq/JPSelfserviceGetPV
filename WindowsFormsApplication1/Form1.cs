using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Collections;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        ArrayList QiitaQuestion = new ArrayList();
        int qiitaPV = 0;
        int qiitaCounter = 0;

        public Form1()
        {
            InitializeComponent();

            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/fa60d8dbac969784d5c6");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/3541a8da7854c081909b");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/576b27b558c073972c61");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/5a531750a4726cff4586");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/94136fb0d6910e179c73");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/2464e24676d275d6d72b");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/31e7749dc3bdb3d7f778");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/05ddde06b7095cb49338");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/208946de380658a32b2e");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/8613b0060dde38c95315");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/5cde5e00418f454f24a8");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/8ad08450bd803d70250f");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/380ff98ca6e61068b80d");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/739bec538d14fb73ed49");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/9d4598370c30d657dba2");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/501fcc476386862effe8");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/8cf466b888ee91d463c5");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/f80240c5b20bfb53459f");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/3a1d48d013dd4edadba1");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/4ef281d2a5cef02f778c");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/cf698caef08f83db1b18");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/093997805eee02cd2b83");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/ed9a897ffd7a38432ad4");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/a508d76162f692c6c659");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/6c2e9117a828564e30f5");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/23f2e65aa128415fa373");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/f970be7d0c1200bd08e3");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/23aa00a6db42617eb56a");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/d3e4e8bc5d1ab555f2bb");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/a92e269bb173eec4e6e8");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/0b4bf4e1ef4a9bb038fa");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/def763cdbbfe354702a6");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/07edba1a9b935ad2e777");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/71b03f39b6965c50258a");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/073ce5f67af7e9f8e092");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/0e49c9ccecef1f9ab01c");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/53c229a5174d8c33dd5f");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/6216ba9034074d9fd1ee");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/64f13713aea05a06d678");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/b18c8b2243174da743b8");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/de70d4a478be55775788");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/036a76957fdfbd6adca4");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/56a2ac587be9a723b49f");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/10a40c9f135b3623ffe3");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/d8117909683295573c08");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/d626c665eee254ab71c7");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/e768939cb9d4b2df2c87");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/3d43739552b47bb1ca08");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/f349b7b881aba1868fec");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/e23c7b6a01ba8ab462cc");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/1d93bf0344bba01dbdfe");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/c7894523be40aafcaef3");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/c6e7dc461a8fe01875fb");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/fdb75cd8571ee93880f7");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/e48392c1deec44b9c454");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/1fb00df2544686c1ab46");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/8efa4ace4a5eedb1d09e");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/d7f59605ac4db3bc1ce1");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/332925d8db55ab83bc6b");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/3f40d59858b16c487929");
            QiitaQuestion.Add("http://qiita.com/PayPal_MTS/items/6cc2fc56e26afbb31aa3");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxYahooPV.Text = "获取中...";
            textBoxQiitaPV.Text = "获取中...";
            textBoxSFPV.Text = "获取中...";

            textBoxYahooPV.Text = CalYahooPV().ToString();
            textBoxSFPV.Text = CalSFPV().ToString();
            //CalQiitaPV();
            
            //this.label5.Text = CalQiitaPV().ToString();//Qiita的数字在webBrowser1_DocumentCompleted中设置。
        }

        public int GetYahooPV(string URL)
        {
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(URL);
            // If required by the server, set the credentials.
            //request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Display the status.
            //MessageBox.Show(response.StatusDescription);
            //Console.WriteLine(response.StatusDescription);
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);

            //string postData = "username=" + strIMSPhone + "&password=" + strIMSPwd + "&type=2" + "&utf8=✓";
            //CookieContainer cookie = new CookieContainer();
            //if (PostLogin(postData, "https://qiita.com/login", ref cookie).Equals("ok"))
            //{
            //    string strCont = PostRequest("", post_getContJsonData, cookie);
            //}

            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            //截取数据
            //int i = responseFromServer.IndexOf("<i class=\"fa fa - eye\"></i>");
            string startStr = "閲覧数：<span class=\"readerNumP\"><span class=\"bold\">";
            string endStr = "</span></span></li>";
            int i = responseFromServer.IndexOf(startStr);
            string temp = responseFromServer.Substring(i);//閲覧数：<span class=\"readerNumP\"><span class=\"bold\">......</span></span></li>......
            int j = temp.IndexOf(endStr);
            string dataBid = temp.Substring(startStr.Length, j - startStr.Length);

            // Display the content.
            //MessageBox.Show(dataBid);
            //Console.WriteLine(responseFromServer);
            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();

            return int.Parse(dataBid);
        }

        public int CalYahooPV()
        {
            int totalPV = 0;
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384937");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384938");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384939");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384940");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384942");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384943");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384944");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384945");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384946");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384947");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384949");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384951");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384952");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384953");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384954");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384955");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384956");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384957");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n384959");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385184");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385185");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385186");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385187");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385188");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385189");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385190");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385191");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385192");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385193");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385194");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385195");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385197");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385198");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385199");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385200");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385200");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385201");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385203");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385204");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385205");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385206");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385207");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385208");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385209");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385210");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385211");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n385212");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395571");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395572");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395575");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395576");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395577");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395578");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395579");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395580");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395581");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395582");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395583");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395584");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n395585");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n396322");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n396323");
            totalPV += GetYahooPV("http://note.chiebukuro.yahoo.co.jp/detail/n396325");

            return totalPV;
        }

        //先Navigate第一个网页，之后通过webBrowser1_DocumentCompleted方法来循环Navigate，直到结束，最后数字在webBrowser1_DocumentCompleted中设置。
        public void CalQiitaPV()
        {
            webBrowser1.ScriptErrorsSuppressed = true;
            qiitaPV = 0;
            qiitaCounter = 0;
            webBrowser1.Navigate(QiitaQuestion[qiitaCounter].ToString());
        }

        public int GetSFPV(string URL)
        {
            // Create a request for the URL.   
            WebRequest request = WebRequest.Create(URL);
            // Get the response.
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            // Get the stream containing content returned by the server.
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream, Encoding.UTF8);
            // Read the content.
            string responseFromServer = reader.ReadToEnd();
            //截取数据
            string startStr = "<p class=\"label-key\">閲覧回数</p>\r\n\t\t\t                </td>\r\n\r\n\t\t\t                <td style=\"padding-left: 10px\">\r\n\t\t\t                    <p class=\"label-key\">\r\n\t\t\t                        <b>";
            string endStr = " 回</b>\r\n\t\t\t";
            int i = responseFromServer.IndexOf(startStr);
            string temp = responseFromServer.Substring(i);//閲覧数：<span class=\"readerNumP\"><span class=\"bold\">......</span></span></li>......
            int j = temp.IndexOf(endStr);
            string dataBid = temp.Substring(startStr.Length, j - startStr.Length);

            // Cleanup the streams and the response.
            reader.Close();
            dataStream.Close();
            response.Close();

            return int.Parse(dataBid);
        }

        public int CalSFPV()
        {
            int totalPV = 0;

            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25009/paypal%E3%82%A2%E3%82%AB%E3%82%A6%E3%83%B3%E3%83%88%E3%81%AA%E3%81%97%E3%81%A7%E3%82%AF%E3%83%AC%E3%82%B8%E3%83%83%E3%83%88%E3%82%AB%E3%83%BC%E3%83%89%E3%81%A7%E6%B1%BA%E6%B8%88%E3%81%99%E3%82%8B%E6%96%B9%E6%B3%95%E3%81%AF%E3%81%82%E3%82%8A%E3%81%BE%E3%81%99%E3%81%8B-%E3%81%A9%E3%81%86%E8%A8%AD%E5%AE%9A%E3%81%99%E3%82%8B%E3%81%AE%E3%81%8B/25011#25011");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25014/paypal-ipn%E8%AD%A6%E5%91%8A%E3%83%A1%E3%83%BC%E3%83%AB%E3%81%8C%E5%B1%8A%E3%81%84%E3%81%9F%E3%82%89%E3%81%A9%E3%81%86%E5%AF%BE%E5%BF%9C%E3%81%97%E3%81%BE%E3%81%99%E3%81%8B/25015#25015");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25020/paypal%E6%B1%BA%E6%B8%88%E3%83%9A%E3%83%BC%E3%82%B8%E3%81%AE%E8%A8%80%E8%AA%9E%E3%81%AF%E3%81%A9%E3%81%86%E8%A8%AD%E5%AE%9A%E3%81%97%E3%81%BE%E3%81%99%E3%81%8B/25021#25021");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25023/paypal%E6%B1%BA%E6%B8%88%E3%83%9A%E3%83%BC%E3%82%B8%E3%81%AE%E3%82%A8%E3%83%A9%E3%83%BC-%E3%83%87%E3%83%BC%E3%82%BF%E3%81%8C%E5%85%A5%E5%8A%9B%E6%96%87%E5%AD%97%E3%82%BB%E3%83%83%E3%83%88%E3%81%BE%E3%81%9F%E3%81%AF%E3%83%87%E3%83%95%E3%82%A9%E3%83%AB%E3%83%88%E3%81%AE%E3%82%A8%E3%83%B3%E3%82%B3%E3%83%BC%E3%83%87%E3%82%A3%E3%83%B3%E3%82%B0%E3%81%AB%E4%B8%80%E8%87%B4%E3%81%97%E3%81%BE%E3%81%9B%E3%82%93/25024#25024");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25026/paypal%E3%81%AEapi%E6%83%85%E5%A0%B1-api%E3%83%A6%E3%83%BC%E3%82%B6%E3%83%BC%E5%90%8D-api%E3%83%91%E3%82%B9%E3%83%AF%E3%83%BC%E3%83%89-api%E7%BD%B2%E5%90%8D-%E3%81%AE%E5%8F%96%E5%BE%97%E6%96%B9%E6%B3%95");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25029/paypal%E3%81%A7%E3%82%AF%E3%83%AC%E3%82%B8%E3%83%83%E3%83%88%E3%82%AB%E3%83%BC%E3%83%89%E3%81%A7%E6%B1%BA%E6%B8%88%E3%81%97%E3%81%9F%E5%BE%8C-%E3%83%AA%E3%83%80%E3%82%A4%E3%83%AC%E3%82%AF%E3%83%88%E3%81%AF%E8%87%AA%E5%8B%95%E7%9A%84%E3%81%AB%E8%A1%8C%E3%82%8F%E3%82%8C%E3%81%AA%E3%81%84/25030#25030");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25033/paypal%E3%81%AEapi%E3%82%A8%E3%83%A9%E3%83%BC%E3%82%B3%E3%83%BC%E3%83%8910002/25034#25034");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25036/paypal%E3%81%AE%E5%8F%96%E5%BC%95%E8%A9%B3%E7%B4%B0%E3%81%AB%E9%85%8D%E9%80%81%E4%BD%8F%E6%89%80%E6%83%85%E5%A0%B1%E3%81%8C%E3%81%AA%E3%81%84/25037#25037");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25089/paypal%E3%81%AEapi%E3%82%A8%E3%83%A9%E3%83%BC%E3%82%B3%E3%83%BC%E3%83%8910412%E3%81%AB%E3%81%A4%E3%81%84%E3%81%A6%E6%95%99%E3%81%88%E3%81%A6%E3%81%8F%E3%81%A0%E3%81%95%E3%81%84/25090#25090");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25096/paypal%E3%81%AEipn%E3%81%AE%E3%83%9D%E3%82%B9%E3%83%88%E3%83%90%E3%83%83%E3%82%AF%E3%81%A7invalid%E6%A4%9C%E8%A8%BC%E7%B5%90%E6%9E%9C%E3%81%AE%E5%AF%BE%E5%BF%9C%E6%96%B9%E6%B3%95/25097#25097");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/25101/%E8%87%AA%E5%88%86%E3%81%AE%E3%82%B5%E3%82%A4%E3%83%88%E3%81%AE%E5%8F%96%E5%BC%95%E3%82%B9%E3%83%86%E3%83%BC%E3%82%BF%E3%82%B9%E3%81%A8paypal%E3%81%AE%E5%8F%96%E5%BC%95%E3%82%B9%E3%83%86%E3%83%BC%E3%82%BF%E3%82%B9%E3%82%92%E5%90%8C%E6%9C%9F%E3%81%99%E3%82%8B%E6%96%B9%E6%B3%95/25102#25102");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/29047/%E5%AE%9A%E6%9C%9F%E6%94%AF%E6%89%95%E3%81%84%E3%81%AEpaypal-rest-api%E3%82%92%E5%AE%9F%E8%A3%85%E3%81%99%E3%82%8B%E6%96%B9%E6%B3%95%E3%82%92%E6%95%99%E3%81%88%E3%81%A6%E3%81%8F%E3%81%A0%E3%81%95%E3%81%84/29048#29048");
            totalPV += GetSFPV("http://ja.stackoverflow.com/questions/29052/paypal-php-sdk%E3%81%AE%E4%BD%BF%E7%94%A8%E6%99%82%E3%81%AE%E3%82%A8%E3%83%A9%E3%83%BC%E3%81%AB%E3%81%A4%E3%81%84%E3%81%A6/29053#29053");

            return totalPV;
        }

        //public static string PostLogin(string postData, string requestUrlString, ref CookieContainer cookie)
        //{
        //    ASCIIEncoding encoding = new ASCIIEncoding();
        //    byte[] data = encoding.GetBytes(postData);
        //    //向服务端请求
        //    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(requestUrlString);
        //    myRequest.Method = "POST";
        //    myRequest.ContentType = "application/x-www-form-urlencoded";
        //    myRequest.ContentLength = data.Length;
        //    myRequest.CookieContainer = new CookieContainer();
        //    Stream newStream = myRequest.GetRequestStream();
        //    newStream.Write(data, 0, data.Length);
        //    newStream.Close();
        //    //将请求的结果发送给客户端(界面、应用)
        //    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
        //    cookie.Add(myResponse.Cookies);
        //    StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
        //    return reader.ReadToEnd();
        //}

        //public static string PostRequest(string postData, string requestUrlString, CookieContainer cookie)
        //{
        //    ASCIIEncoding encoding = new ASCIIEncoding();
        //    byte[] data = encoding.GetBytes(postData);
        //    HttpWebRequest myRequest = (HttpWebRequest)WebRequest.Create(requestUrlString);
        //    myRequest.Method = "POST";
        //    myRequest.ContentType = "application/x-www-form-urlencoded";
        //    myRequest.ContentLength = data.Length;
        //    myRequest.CookieContainer = cookie;
        //    Stream newStream = myRequest.GetRequestStream();
        //    newStream.Write(data, 0, data.Length);
        //    newStream.Close();
        //    HttpWebResponse myResponse = (HttpWebResponse)myRequest.GetResponse();
        //    StreamReader reader = new StreamReader(myResponse.GetResponseStream(), Encoding.UTF8);
        //    return reader.ReadToEnd();
        //}

        //get qiita PV
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            if (webBrowser1.ReadyState != WebBrowserReadyState.Complete)
            {
                return;
            }
            string contentStr = webBrowser1.DocumentText;
            //截取数据
            string startStr = "<div class=\"ArticleAsideHeader__viewCount\">";
            string endStr = "<span>views</span></div>";
            int i = contentStr.IndexOf(startStr);
            string temp = contentStr.Substring(i);//閲覧数：<span class=\"readerNumP\"><span class=\"bold\">......</span></span></li>......
            int j = temp.IndexOf(endStr);
            string dataBid = temp.Substring(startStr.Length, j - startStr.Length);

            qiitaPV += int.Parse(dataBid);
            this.textBoxQiitaPV.Text = qiitaPV.ToString() + "...";
            qiitaCounter++;
            if (qiitaCounter < QiitaQuestion.Count)
            {
                webBrowser1.Navigate(QiitaQuestion[qiitaCounter].ToString());
            }
            else
            {
                webBrowser1.Stop();
                this.textBoxQiitaPV.Text = qiitaPV.ToString();
            }
        }
    }
}
