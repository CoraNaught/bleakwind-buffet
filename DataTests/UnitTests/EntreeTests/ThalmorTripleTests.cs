/*
 * Author: Zachery Brunner
 * Modified By: Corrie Naughton
 * Class: ThalmorTripleTests.cs
 * Purpose: Test the ThalmorTriple.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThalmorTripleTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.IsAssignableFrom<Entree>(thalmorTriple);
            Assert.IsAssignableFrom<IOrderItem>(thalmorTriple);
        }
        [Fact]
        public void ShouldIncludeBunByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Bun);
        }

        [Fact]
        public void ShouldIncludeKetchupByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Ketchup);
        }

        [Fact]
        public void ShouldIncludeMustardByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Mustard);
        }

        [Fact]
        public void ShouldIncludePickleByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Pickle);
        }

        [Fact]
        public void ShouldIncludeCheeseByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Cheese);
        }

        [Fact]
        public void ShouldIncludeTomatoByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Tomato);
        }

        [Fact]
        public void ShouldIncludeLettuceByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Lettuce);
        }

        [Fact]
        public void ShouldIncludeMayoByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Mayo);
        }

        [Fact]
        public void ShouldIncludeBaconByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Bacon);
        }

        [Fact]
        public void ShouldIncludeEggByDefault()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Egg);
        }

        [Fact]
        public void ShouldBeAbleToSetBun()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Bun = false;
            Assert.False(thalmorTriple.Bun);
        }

        [Fact]
        public void ShouldBeAbleToSetKetchup()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Ketchup = false;
            Assert.False(thalmorTriple.Ketchup);
        }

        [Fact]
        public void ShouldBeAbleToSetMustard()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Mustard = false;
            Assert.False(thalmorTriple.Mustard);
        }

        [Fact]
        public void ShouldBeAbleToSetPickle()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Pickle = false;
            Assert.False(thalmorTriple.Pickle);
        }

        [Fact]
        public void ShouldBeAbleToSetCheese()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Cheese = false;
            Assert.False(thalmorTriple.Cheese);
        }

        [Fact]
        public void ShouldBeAbleToSetTomato()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Tomato = false;
            Assert.False(thalmorTriple.Tomato);
        }

        [Fact]
        public void ShouldBeAbleToSetLettuce()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Lettuce = false;
            Assert.False(thalmorTriple.Lettuce);
        }

        [Fact]
        public void ShouldBeAbleToSetMayo()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Mayo = false;
            Assert.False(thalmorTriple.Mayo);
        }

        [Fact]
        public void ShouldBeAbleToSetBacon()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Bacon = false;
            Assert.False(thalmorTriple.Bacon);
        }

        [Fact]
        public void ShouldBeAbleToSetEgg()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            thalmorTriple.Egg = false;
            Assert.False(thalmorTriple.Egg);
        }

        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Price == 8.32);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.True(thalmorTriple.Calories == 943);
        }

        [Theory]
        [InlineData(true, true, true, true, true, true, true, true, true, true)]
        [InlineData(false, false, false, false, false, false, false, false, false, false)]
        public void ShouldReturnCorrectSpecialInstructions(bool includeBun, bool includeKetchup, bool includeMustard,
                                                                    bool includePickle, bool includeCheese, bool includeTomato,
                                                                    bool includeLettuce, bool includeMayo,
                                                                    bool includeBacon, bool includeEgg)
        {

            ThalmorTriple thalmorTriple = new ThalmorTriple();
            List<string> specialInstructions = new List<string>();
            if (!includeBun)
            {
                thalmorTriple.Bun = false;
                specialInstructions.Add("Hold bun");
            }
            if (!includeKetchup)
            {
                thalmorTriple.Ketchup = false;
                specialInstructions.Add("Hold ketchup");
            }
            if (!includeMustard)
            {
                thalmorTriple.Mustard = false;
                specialInstructions.Add("Hold mustard");
            }
            if (!includePickle)
            {
                thalmorTriple.Pickle = false;
                specialInstructions.Add("Hold pickle");
            }
            if (!includeCheese)
            {
                thalmorTriple.Cheese = false;
                specialInstructions.Add("Hold cheese");
            }
            if (!includeTomato)
            {
                thalmorTriple.Tomato = false;
                specialInstructions.Add("Hold tomato");
            }
            if (!includeLettuce)
            {
                thalmorTriple.Lettuce = false;
                specialInstructions.Add("Hold lettuce");
            }
            if (!includeMayo)
            {
                thalmorTriple.Mayo = false;
                specialInstructions.Add("Hold mayo");
            }
            if (!includeBacon)
            {
                thalmorTriple.Bacon = false;
                specialInstructions.Add("Hold bacon");
            }
            if (!includeEgg)
            {
                thalmorTriple.Egg = false;
                specialInstructions.Add("Hold egg");
            }
            Assert.Equal(thalmorTriple.SpecialInstructions, specialInstructions);
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThalmorTriple thalmorTriple = new ThalmorTriple();
            Assert.Equal(thalmorTriple.ToString(), "Thalmor Triple");
        }

        [Fact]
        public void ChangingBunNotifiesBunProperty()
        {
            var TT = new DoubleDraugr();

            Assert.PropertyChanged(TT, "Bun", () =>
            {
                TT.Bun = true;
            });

            Assert.PropertyChanged(TT, "Bun", () =>
            {
                TT.Bun = false;
            });
        }


        [Fact]
        public void ChangingKetchupNotifiesKetchupProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Ketchup", () =>
            {
                TT.Ketchup = true;
            });

            Assert.PropertyChanged(TT, "Ketchup", () =>
            {
                TT.Ketchup = false;
            });
        }
        [Fact]
        public void ChangingMustardNotifiesMustardProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Mustard", () =>
            {
                TT.Mustard = true;
            });

            Assert.PropertyChanged(TT, "Mustard", () =>
            {
                TT.Mustard = false;
            });
        }
        [Fact]
        public void ChangingPickleNotifiesPickleProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Pickle", () =>
            {
                TT.Pickle = true;
            });

            Assert.PropertyChanged(TT, "Pickle", () =>
            {
                TT.Pickle = false;
            });
        }

        [Fact]
        public void ChangingCheeseNotifiesCheeseProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Cheese", () =>
            {
                TT.Cheese = true;
            });

            Assert.PropertyChanged(TT, "Cheese", () =>
            {
                TT.Cheese = false;
            });
        }

        [Fact]
        public void ChangingTomatoNotifiesTomatoProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Tomato", () =>
            {
                TT.Tomato = true;
            });

            Assert.PropertyChanged(TT, "Tomato", () =>
            {
                TT.Tomato = false;
            });
        }
        [Fact]
        public void ChangingLettuceNotifiesLettuceProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Lettuce", () =>
            {
                TT.Lettuce = true;
            });

            Assert.PropertyChanged(TT, "Lettuce", () =>
            {
                TT.Lettuce = false;
            });
        }

        [Fact]
        public void ChangingMayoNotifiesMayoProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Mayo", () =>
            {
                TT.Mayo = true;
            });

            Assert.PropertyChanged(TT, "Mayo", () =>
            {
                TT.Mayo = false;
            });
        }

        [Fact]
        public void ChangingBaconNotifiesBaconProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Bacon", () =>
            {
                TT.Bacon = true;
            });

            Assert.PropertyChanged(TT, "Bacon", () =>
            {
                TT.Bacon = false;
            });
        }

        [Fact]
        public void ChangingEggNotifiesEggProperty()
        {
            var TT = new ThalmorTriple();

            Assert.PropertyChanged(TT, "Egg", () =>
            {
                TT.Egg = true;
            });

            Assert.PropertyChanged(TT, "Egg", () =>
            {
                TT.Egg = false;
            });
        }
    }
}