using System;
using System.Collections.Generic;

public class KodePos
{
    private Dictionary<string, string> dataKodePos;

    public KodePos()
    {
        dataKodePos = new Dictionary<string, string>
        {
            { "Batununggal", "40266" }, { "Kujangsari", "40287" },
            { "Mengger", "40267" }, { "Wates", "40256" },
            { "Cijaura", "40287" }, { "Jatisari", "40286" },
            { "Margasari", "40286" }, { "Sekejati", "40286" },
            { "Kebonwaru", "40272" }, { "Maleer", "40274" }
        };
    }

    public string GetKodePos(string kelurahan)
    {
        return dataKodePos.ContainsKey(kelurahan) ? dataKodePos[kelurahan] : "Kelurahan tidak ditemukan";
    }
}

public class DoorMachine
{
    public enum State { Terkunci, Terbuka }
    private State currentState;

    public DoorMachine()
    {
        currentState = State.Terkunci;
        Console.WriteLine("Pintu terkunci");
    }

    public void Activate(string command)
    {
        if (currentState == State.Terkunci && command == "BukaPintu")
        {
            currentState = State.Terbuka;
            Console.WriteLine("Pintu tidak terkunci");
        }
        else if (currentState == State.Terbuka && command == "KunciPintu")
        {
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci");
        }
        else
        {
            Console.WriteLine("Pintu masih " + (currentState == State.Terkunci ? "terkunci" : "tidak terkunci"));
        }
    }
}

// --- Class Utama ---
class Program
{
    static void Main(string[] args)
    {
        // Simulasi KodePos
        Console.WriteLine("=== Simulasi KodePos ===");
        KodePos kp = new KodePos();
        Console.WriteLine("Kode Pos Batununggal: " + kp.GetKodePos("Batununggal"));

        // Simulasi DoorMachine
        Console.WriteLine("\n=== Simulasi DoorMachine ===");
        DoorMachine door = new DoorMachine();
        door.Activate("BukaPintu");
        door.Activate("BukaPintu");
        door.Activate("KunciPintu");
    }
}