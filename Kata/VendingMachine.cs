namespace Kata;

public class VendingMachine
{
    private double currentAmount = 0.0;
    public double Amount()
    {
        return currentAmount;
    }

    public void InsertCoin(double coinValue, string coinType)
    {
        if (coinType == "nickels")
        {
            currentAmount += coinValue;
        }

        if (coinType == "dimes")
        {
            currentAmount += coinValue;
        }

        if (coinType == "quarters")
        {
            currentAmount += coinValue;
        }
    }
}