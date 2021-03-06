﻿/*
 * Author: Zachery Brunner
 * Modified Bu: Corrie Naughton
 * Class: ThugsTBoneTests.cs
 * Purpose: Test the ThugsTBone.cs class in the Data library
 */
using Xunit;

using BleakwindBuffet.Data;
using BleakwindBuffet.Data.Entrees;
using System.Collections.Generic;
using System.ComponentModel;

namespace BleakwindBuffet.DataTests.UnitTests.EntreeTests
{
    public class ThugsTBoneTests
    {
        [Fact]
        public void ShouldBeAEntree()
        {
            ThugsT_Bone thugsT_Bone = new ThugsT_Bone();
            Assert.IsAssignableFrom<Entree>(thugsT_Bone);
            Assert.IsAssignableFrom<IOrderItem>(thugsT_Bone);
        }
        [Fact]
        public void ShouldBeAbleToGetDisciption()
        {
            ThugsT_Bone t = new ThugsT_Bone();
            Assert.Equal(t.Description, "Juicy T-Bone, not much else to say.");
        }
        [Fact]
        public void ShouldBeAssignableFromINotifyPropertyChanged()
        {
            ThugsT_Bone thugsT_Bone = new ThugsT_Bone();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(thugsT_Bone);
        }
        [Fact]
        public void ShouldReturnCorrectPrice()
        {
            ThugsT_Bone thugsT_Bone = new ThugsT_Bone();
            Assert.True(thugsT_Bone.Price == 6.44);
        }

        [Fact]
        public void ShouldReturnCorrectCalories()
        {
            ThugsT_Bone thugsT_Bone = new ThugsT_Bone();
            Assert.True(thugsT_Bone.Calories == 982);
        }

        [Fact]
        public void ShouldReturnCorrectSpecialInstructions()
        {
            ThugsT_Bone thugsT_Bone = new ThugsT_Bone();
            Assert.Equal(thugsT_Bone.SpecialInstructions, new List<string>());
        }

        [Fact]
        public void ShouldReturnCorrectToString()
        {
            ThugsT_Bone thugsT_Bone = new ThugsT_Bone();
            Assert.Equal(thugsT_Bone.ToString(), "Thugs T-Bone");
        }
    }
}