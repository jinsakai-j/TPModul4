using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> dataKodePos;

    public KodePos()
    {
        dataKodePos = new Dictionary<string, string>
        {
            { "Batununggal", "40266" },
            { "Kujangsari", "40287" },
            { "Mengger", "40267" },
            { "Wates", "40256" },
            { "Cijaura", "40287" },
            { "Jatisari", "40286" },
            { "Margasari", "40286" },
            { "Sekejati", "40286" },
            { "Kebonwaru", "40272" },
            { "Maleer", "40274" }
        };
    }

    public string GetKodePos(string kelurahan)
    {
        if (dataKodePos.ContainsKey(kelurahan))
        {
            return dataKodePos[kelurahan];
        }
        return "Kelurahan tidak ditemukan";
    }
}

class Program
{
    static void Main(string[] args)
    {
        KodePos kp = new KodePos();

        Console.WriteLine("Kode Pos Batununggal: " + kp.GetKodePos("Batununggal"));
        Console.WriteLine("Kode Pos Jatisari: " + kp.GetKodePos("Jatisari"));
    }
}