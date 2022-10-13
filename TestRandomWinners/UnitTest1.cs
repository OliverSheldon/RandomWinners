using Xunit;
using Moq;
using Domain.Context;
using System.Collections.Generic;
using Domain.Models;
using System;
using RandomWinners.Models;
using Microsoft.EntityFrameworkCore;

namespace TestRandomWinners
{
    public class TestWinnersRequest
    {
        private PersonContext _context { get; set; }

        private Winners _winners { get; set; }
        public TestWinnersRequest()
        {
            //Best not to use a real DB as this could fail and invalidate the tests
            var options = new DbContextOptionsBuilder<PersonContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;

            _context = new PersonContext(options);

            _winners = new Winners(_context); 
             
        }

        [Fact]
        public void GetOneWinner()
        {
            WinnersRequest wr = new WinnersRequest();
            wr.number = 1;
            
            Assert.Equal(1, _winners.GetWinners(wr).Count);
        }

        [Fact]
        public void GetFiveWinner()
        {
            WinnersRequest wr = new WinnersRequest();
            wr.number = 5;
            
            Assert.Equal(5, _winners.GetWinners(wr).Count);
        }

        [Fact]
        public void GetWinnersList()
        {
            WinnersRequest wr = new WinnersRequest();
            wr.number = 5;
            
            Assert.IsType<List<Person>>(_winners.GetWinners(wr));
        }
    }
}