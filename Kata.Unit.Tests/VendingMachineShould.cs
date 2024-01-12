namespace Kata.Unit.Tests;


/*TODO:
   - Maquina no recibe ninguna moneda y te muestra -- Amount = 0.0
   - Maquin recibe una moneda y te da su amount
   - Maquina recibe una moneda valida y te da su -- Amount, suma total
 */
public class VendingMachineShould
{
    [Fact]
    public void display_an_initial_amount()
    {
        var vendingMachine = new VendingMachine();

        var initialAmount = vendingMachine.amount();
        initialAmount.Should().Be(0);
    }
    
    
    [Theory]
    [InlineData(1.0, "nickels")]
    [InlineData(0.1, "dimes")]
    [InlineData(2.0, "quarters")]
    public void insert_a_valid_coin(double coinValue, string coinType)
    {
        var vendingMachine = new VendingMachine();
        
        vendingMachine.insertCoin(coinValue, coinType);

        vendingMachine.amount().Should().Be(coinValue);
    }

}