using System;
using FluentAssertions;
using Machine.Specifications;
using QATest.src;

namespace QATest.test
{
  [Subject("Add Person to Contacts")]
  public class AddressBookSpec
  {
    private static Person p;
    private Establish context = () =>
    {
     p = new Person("Fred", "Here", 0);
    };

    private Because of = () =>
    {
      Contacts.Add(p);
    };



    private It should_have_a_person = () =>
     {
       Contacts.List().Count.Should().Be(1);
       Contacts.List().Find(c => c.ID == p.ID).Should().NotBeNull();
     };
  }
}