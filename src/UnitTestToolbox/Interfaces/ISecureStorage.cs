namespace UnitTestToolbox.Interfaces
{
  // Make Xamarin.Essentials.SecureStorage unittestable
  internal interface ISecureStorage
  {
    Task<string> GetAsync(string key);

    Task SetAsync(string key, string value);

    bool Remove(string key);

    void RemoveAll();
  }
}
