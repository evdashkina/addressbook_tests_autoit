using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace addressbook_tests_autoit
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void TestGroupCreation()
        {

            //List<GroupData> 
                int oldGroups = app.Groups.GetGroupList();


            GroupData newGroup = new GroupData()
            {
                Name = "test"
            };

            app.Groups.Add(newGroup);


            //List<GroupData> 
            int    newGroups = app.Groups.GetGroupList();
            oldGroups = oldGroups + 1;
            //oldGroups.Add(newGroup);
           // oldGroups.Sort();
           // newGroups.Sort();

            Assert.AreEqual(oldGroups, newGroups);

        }
    }
}
