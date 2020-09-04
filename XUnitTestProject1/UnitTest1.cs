using System;
using Xunit;
using BleakwindBuffet.Data.Drinks;
using BleakwindBuffet.Data.Entrees;
using BleakwindBuffet.Data.Sides;
using BleakwindBuffet.Data.Enums;
namespace XUnitTestProject1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            AretinoAppleJuice juice = new AretinoAppleJuice();
            SailorSode sailorSode = new SailorSode();
            sailorSode.Size = Size.Large;
            Assert.True(sailorSode.Price == 2.07);
            Assert.Equal(juice.Ice, false);
            sailorSode.Ice = false;
            Console.WriteLine(sailorSode.ToString());
        }
        [Fact]
        public void Test2()
        {
            BriarheartBurger briarheartBurger = new BriarheartBurger();
            DoubleDraugr doubleDraugr = new DoubleDraugr();
            GardenOrcOmlette gardenOrcOmlette = new GardenOrcOmlette();
            PhillyPoacher phillyPoacher = new PhillyPoacher();
            SmokehouseSkeleton smokehouseSkeleton = new SmokehouseSkeleton();
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            ThugsT_Bone thugsT_Bone = new ThugsT_Bone();
            Assert.Equal(briarheartBurger.Bun, true);
            Assert.Equal(briarheartBurger.ToString(), "Briarheart Burger");
            Assert.Equal(doubleDraugr.Mayo, true);
            Assert.Equal(doubleDraugr.ToString(), "Double Draugr");
            Assert.Equal(gardenOrcOmlette.Mushrooms, true);
            Assert.Equal(phillyPoacher.Sirloin, true);
            Assert.Equal(smokehouseSkeleton.PanCake, true);
            Assert.Equal(thalmorTriple.Pickle, true);
            briarheartBurger.Pickle = false;
            Assert.Equal(briarheartBurger.SpecialInstructions, new string[] { "Hold pickle" });
        }
    }
}
