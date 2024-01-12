﻿namespace Kata;

public class VendingMachine
{
    private double currentAmount = 0.0;
    public double amount()
    {
        return currentAmount;
    }

    public void insertCoin(double coinValue, string coinType)
    {
        if (coinType == "nickels")
        {
            currentAmount += coinValue;
        }
    }
}