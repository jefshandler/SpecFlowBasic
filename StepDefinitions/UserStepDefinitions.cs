using AutoFixture;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowBasic.StepDefinitions;

[Binding]
public class UserStepDefinitions
{
    [Given(@"I enter random user data")]
    public void GivenIEnterRandomUserData()
    {
        var person = new Fixture()
            .Build<User>()
            .With(x => x.Email, "teste@email.com")
            .Create();
        Console.WriteLine($"The user {person.Name} has email {person.Email} has address {person.Address} has phone is {person.phone}");
    }

    public record User
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int phone { get; set; }  

    }


}
