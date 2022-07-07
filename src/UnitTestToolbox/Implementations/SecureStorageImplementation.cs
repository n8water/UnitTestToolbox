using UnitTestToolbox.Interfaces;
using Xamarin.Essentials;

namespace UnitTestToolbox.Implementations
{
  public class SecureStorageImplementation : ISecureStorage
  {
    public async Task<string> GetAsync(string key)
    {
      return await SecureStorage.GetAsync(key);
    }

    public async Task SetAsync(string key, string value)
    {
      await SecureStorage.SetAsync(key, value);
    }

    public bool Remove(string key)
    {
      return SecureStorage.Remove(key);
    }

    public void RemoveAll()
    {
      SecureStorage.RemoveAll();
    }
  }
}
