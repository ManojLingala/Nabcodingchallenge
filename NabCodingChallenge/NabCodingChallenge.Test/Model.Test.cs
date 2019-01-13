using System;
using NabCodingChallenge.Model.Entities;
using Newtonsoft.Json;
using Xunit;
using System.Collections.Generic;
using NabCodingChallenge.Model.Interfaces;
namespace NabCodingChallenge.Test
{
    /// <summary>
    /// All those unit test below to make sure that the meta attibute is correct 
    /// Assume we use JSON.NET cross the application to do desirialize string to oject with default config.
    /// </summary>
    /// [

    public class Model
    {
     
		[Fact]
		public void Owner_ShouldDeserialize_WhenMissingName()
		{
			string input = "{\"pets\": [{\"name\":\"Garfield\",\"type\":\"Cat\"}]}";
			var owner = JsonConvert.DeserializeObject<Owner>(input);
            Assert.NotNull(owner);
			Assert.Single(owner.Pets);
            Assert.Equal("Cat",owner.Pets[0].Type);
		}

        [Fact]
        public void Owner_ShouldDeserialize_WhenMissingCarsInInput()
        {
            string input = "{name: \"Bob\"}";
            var owner = JsonConvert.DeserializeObject<Owner>(input);
            Assert.Equal("Bob", owner.Name);
            Assert.Empty(owner.Pets);
        }

        [Fact]
        public void Owner_ShouldDeserialize_WhenInputIsEmpty()
        {
            string input = "{}";
            var owner = JsonConvert.DeserializeObject<Owner>(input);
            Assert.NotNull(owner);
            Assert.True(string.IsNullOrEmpty(owner.Name));
            Assert.Empty(owner.Pets);
        }

        [Fact]
        public void List_Owner_ShouldHas2Owner()
        {
            string input = "[{\"name\":\"Bob\",\"gender\":\"Male\",\"pets\":[{\"name\":\"Garfield\",\"type\":\"Cat\"}]},{\"name\":\"Jennifer\",\"gender\":\"Female\",\"pets\":[{\"name\":\"Garfield\",\"type\":\"Cat\"}]}]";
            var list = JsonConvert.DeserializeObject<ServiceResponse>(input);
            
            Assert.Equal(2, list.Count);
            Assert.Equal("Bob", list[0].Name);
            Assert.Equal("Jennifer", list[1].Name);
        }
        [Fact]
        public void List_Owner_ShouldEmpty_WhenEmptyInput()
        {
            string input = "[]";
            var list = JsonConvert.DeserializeObject<ServiceResponse>(input);
            Assert.Empty(list);
        }
       
    }
}
