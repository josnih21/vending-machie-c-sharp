namespace Kata.Unit.Tests;


/*TODO:
   - Maquina no recibe ninguna moneda y te muestra -- Amount = 0.0
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
    public void insert_a_new_coin()
    {
        var vendingMachine = new VendingMachine();

        vendingMachine.insertCoin(1.0);

        var expected = 1.0;
        vendingMachine.amount().Should().Be(expected);
    }
}