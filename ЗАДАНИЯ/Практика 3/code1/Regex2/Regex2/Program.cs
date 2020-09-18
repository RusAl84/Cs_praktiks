using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "Company name: Contoso, Inc.";
            Match m = Regex.Match(input, @"Company name: (.*$)");
            Console.WriteLine(m.Groups[1]);
            string inputString = "type=\"text/javascript\">document.write(\"Например, <span id=sample onclick=\"p('next.example');sample(this)\">\"+'салат весенний'+\"</\"+\"span>\")</script> </div></table></div><table id=tabs><tr><th>Везде<td><a href=\"http://news.yandex.ru\"onclick=\"p('next.tabs.news')\">Новости</a><td><a href=\"http://market.yandex.ru/?clid=505\"onclick=\"p('next.tabs.market')\">Маркет</a><td><a href=\"http://maps.yandex.ru\"onclick=\"p('next.tabs.maps')\">Карты</a><td><a href=\"http://slovari.yandex.ru\"onclick=\"p('next.tabs.slovari')\">Словари</a><td><a href=\"http://blogs.yandex.ru:8080\"onclick=\"p('next.tabs.blogs')\">Блоги</a><td><a href=\"http://images.yandex.ru\"onclick=\"p('next.tabs.images')\">Картинки</a><td class=all><a href=\"http://www.yandex.ru/all_services.html\"onclick=\"p('next.tabs.all')\">Все службы…</a></table><script type=\"text/javascript\">init()</script></form></table><table id=body lang=ru><col width=\"18%\"><col width=\"82%\"><tr><th><div id=mail class=form><form action=\"http://passport.yandex.ru/passport?mode=auth&amp;retpath=http://mail.yandex.ru:80\"method=post><h2><a href=\"http://mail.yandex.ru\"onclick=\"p('next.mail.title')\">Почта</a></h2><div class=f><div class=i><label for=l onclick=\"this.nextSibling.focus()\">логин </label><input id=l name=login onfocus=\"clean(this)\"></div><div class=i><label for=s onclick=\"this.nextSibling.focus()\">пароль </label><input id=s name=passwd type=password onfocus=\"clean(this)\"></div><div class=t><input id=t name=twoweeks type=checkbox value=yes> <label for=t>запомнить меня</label></div><script type=\"text/javascript\">cleanLogin()</script><input type=submit onclick=\"p('next.mail.login')\"value=\"Войти\"><div><a href=\"http://passport.yandex.ru/passport?mode=remember\"onclick=\"p('next.mail.remember')\">Забыли пароль?</a></div></div><p><a hr";

            DumpHrefs(inputString);

        }
        static void DumpHrefs(String inputString)
        {
            Regex r; Match m;



            r = new Regex("href\\s*=\\s*(?:\"(?<1>[^\"]*)\"|(?<1>\\S+))",
            RegexOptions.IgnoreCase | RegexOptions.Compiled);
            for (m = r.Match(inputString); m.Success; m = m.NextMatch())
            {

                Console.WriteLine("Found href " + m.Groups[1] + " at " + m.Groups[1].Index);
              //  Console.WriteLine(Extension(m.Groups[1].ToString()));
            }
        }

        //static String Extension(String url)
        //{
        //    Regex r = new Regex(@"^(?<proto>\w+)://[^/]+?(?<port>:\d+)?/",
        //    RegexOptions.Compiled);
        //    string st = "";
        //    if (r.IsMatch(url))
        //        st = r.Match(url).Result("${proto}${port}");
        //    return st;
        //}
    }

}
