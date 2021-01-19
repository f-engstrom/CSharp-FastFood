using System;
using System.Collections.Generic;
using System.Text;
using Csharp_Fastfood_Terminal.Model;
using Xunit;

namespace Csharp_Fastfood_Test
{
    public class KitchenBotShould
    {

        [Fact]
        public void PlaceOrder()
        {

            KitchenBot sut = new KitchenBot();

            Order order = new Order("Wonton Soup");

        }

    }
}
