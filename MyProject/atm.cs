using System;

public class cardHolder{
    public string cardNum { get; set; }
    public int pin { get; set; }

    public string fistName { get; set; }

    public string lastName { get; set; }
    
    public double balance { get; set; }
    
    public cardHolder(string cardNum, int pin, string fistName, string lastName, double balance)
    {
        this.cardNum = cardNum;
        this.pin = pin;
        this.fistName = fistName;
        this.lastName = lastName;
        this.balance = balance;
    }
    public static void Main(string[] args)
    {
        cardHolder hejsan = new cardHolder("123231132", 123, "qwe", "qwe", 10.2);
        Console.WriteLine(hejsan.cardNum);
    }
}

