using ex_2.Components.Pages;
using ex_2.Model;
using static ex_2.Components.Pages.Home;

namespace ex_2.Services
{
    public class UserServices
    {
        private int _nextId = 1;

        public List<UserModel> Users { get; } = new();

        public int NextId() => _nextId++;

        public void Add(UserModel user)
        {
            Users.Add(user);
        }

        public void Update(UserModel updated)
        {
            var index = Users.FindIndex(u => u.UserID == updated.UserID);
            if (index >= 0)
                Users[index] = updated;
        }

        public void Clear()
        {
            Users.Clear();
            _nextId = 1;
        }

        public Task<bool> IsEmailTakenAsync(string? email)
        {
            var taken = Users.Any(u => u.Email == email?.Trim().ToLower());
            return Task.FromResult(taken);
        }
    }
}
