using Domain.Context;
using Domain.Models;

using (var ctx = new PersonContext())
{
    var p1 = new Person() { Forename = "Homer", Surname = "Simpson" };
    var p2 = new Person() { Forename = "Marge", Surname = "Simpson" };
    var p3 = new Person() { Forename = "Bart", Surname = "Simpson" };
    var p4 = new Person() { Forename = "Lisa", Surname = "Simpson" };
    var p5 = new Person() { Forename = "Maggie", Surname = "Simpson" };
    var p6 = new Person() { Forename = "Ned", Surname = "Flanders" };
    var p7 = new Person() { Forename = "Ralph", Surname = "Wiggum" };
    var p8 = new Person() { Forename = "Troy", Surname = "McClure" };
    var p9 = new Person() { Forename = "Hans", Surname = "Moleman" };
    var p10 = new Person() { Forename = "Groundskeeper", Surname = "Willie" };

    ctx.Persons.Add(p1);
    ctx.Persons.Add(p2);
    ctx.Persons.Add(p3);
    ctx.Persons.Add(p4);
    ctx.Persons.Add(p5);
    ctx.Persons.Add(p6);
    ctx.Persons.Add(p7);
    ctx.Persons.Add(p8);
    ctx.Persons.Add(p9);
    ctx.Persons.Add(p10);

    ctx.SaveChanges();
}