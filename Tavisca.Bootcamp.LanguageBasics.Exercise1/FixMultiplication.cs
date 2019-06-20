using System;

namespace Tavisca.Bootcamp.LanguageBasics.Exercise1
{
    public class FixMultiplication
    {
        public string Find(string s)
        {
            int st = s.IndexOf("*"), eq = s.IndexOf("="), qu = s.IndexOf("?");
            if (qu < st)
            {
                int b = Int32.Parse(s.Substring(st + 1, eq - st - 1));
                int c = Int32.Parse(s.Substring(eq + 1));
                int a = c / b;
                string q = s.Substring(qu + 1, st - qu - 1);
                if (Convert.ToDouble(a) != Convert.ToDouble(c) / Convert.ToDouble(b) || q == Convert.ToString(a))
                {
                    return ("-1");
                }
                else
                {
                    string d = Convert.ToString(a);
                    return Convert.ToString(d[qu]);
                }
            }
            else if (qu < eq)
            {
                int a = Int32.Parse(s.Substring(0, st));
                int c = Int32.Parse(s.Substring(eq + 1));
                int b = c / a;
                string q = s.Substring(qu + 1, eq - qu - 1);
                if (Convert.ToDouble(b) != Convert.ToDouble(c) / Convert.ToDouble(a) || q == Convert.ToString(b))
                {
                    return ("-1");
                }
                else
                {
                    string d = Convert.ToString(b);
                    return Convert.ToString(d[qu - st - 1]);
                }
            }
            else
            {
                int a = Int32.Parse(s.Substring(0, st));
                int b = Int32.Parse(s.Substring(st + 1, eq - st - 1));
                int c = a * b;
                string q = s.Substring(qu + 1);
                if (q == Convert.ToString(c))
                {
                    return ("-1");
                }
                else
                {
                    string d = Convert.ToString(c);
                    return Convert.ToString(d[qu - eq - 1]);
                }
            }
        }
    }
}