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

    [Fact]
    public void insert_a_valid_coin()
    {
        var vendingMachine = new VendingMachine();
        
        vendingMachine.insertCoin(1.0, "nickels");
        vendingMachine.insertCoin(0.1, "dimes");

        vendingMachine.amount().Should().Be(1.1);
    }

}