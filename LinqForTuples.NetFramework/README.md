This packege inclide linq extensions for systemValue type

Examples:

var numbers = (-3,-2,-1, 0, 1,2,3).ToArray()
var min =  (12,324,5).Min();
var max =  (12,324,5).Max();

public string[] Options => ("Yes, No", "Maybe").ToArray();

var begin = new Point(10,0);
var end = new Point(0,0);
(begin, end) = (begin,end).Swipe(IsOrderInValid);


List<User> NormalUsers {get;}
List<User> AdminUsers {get;}
List<User> BannedUsers {get;}

RemoveUser(User user) => (NormalUsers, AdminUsers, BannedUsers).ForEach(x => Remove(user));
AllUsers() => (NormalUsers, AdminUsers, BannedUsers).Many();
FindUser(string userID) => (NormalUsers, AdminUsers, BannedUsers).Many().FirstOrDefault(x => x.Id == userID);



