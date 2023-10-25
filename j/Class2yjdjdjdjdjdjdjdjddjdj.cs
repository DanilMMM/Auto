using System;

using System.ComponentModel.DataAnnotations.Schema;
using System.Security.Cryptography;


using System;

class Auto
{
    private string number; //Номер машины m
    private int fuelCapacity; //Кол-во бензина в баке
    private float fuelConsumption; //Расход топлива

    private double milleage;//Пробег
    private double zaprav;
    private double rast;

    public Auto(string number, int fuelCapacity, float fuelConsumption) //Конструктор класса
    {
        this.number = number;
        this.fuelCapacity = fuelCapacity;
        this.fuelConsumption = fuelConsumption;
        this.zaprav = 100;

        this.milleage = 0;
    }

    public double Zapravka()
    {
        Console.WriteLine($"Введите кол-во бензина (в литрах), на которое хотите заправить машину (макс значение:{fuelCapacity}).");
        double fuelAmount = Convert.ToDouble(Console.ReadLine());
        if (zaprav + fuelAmount <= fuelCapacity)
        {
            zaprav += fuelAmount;
            Console.WriteLine($"Машина заправлена на {fuelAmount} литров. Текущее количество топлива: {zaprav} литров.");
        }
        else
        {
            Console.WriteLine("Бак машины переполнен. Невозможно добавить больше топлива.");

        }
        return zaprav;
    }

    public void Drive(double distance)
        
    {
        double rast = distance;
        while (milleage!= rast)
        {
            
            zaprav -= fuelConsumption;
            milleage = +100;
            if (zaprav < 0)
            {
               
                Console.WriteLine($"Пройдено {distance} км. Пробег: {milleage}. Остаток топлива: {zaprav} литров.");
            }
            if (zaprav < fuelCapacity)
            {

                Console.WriteLine($"Недостаточно топлива для прохождения {distance} км. Пожалуйста, заправьте машину.");
                this.Zapravka();
            }
        }
    }

    public void Info()
    {

        Console.WriteLine($"Номер машины: {number}");
        Console.WriteLine($"Количество бензина в баке: {fuelCapacity} литров");
        Console.WriteLine($"Расход топлива на 100 км: {fuelConsumption} литров");
        Console.WriteLine($"Текущее количество топлива: {zaprav } литров");
    }

   


}





    
  

    