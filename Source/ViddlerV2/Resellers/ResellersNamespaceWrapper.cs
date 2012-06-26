using System;
using System.Collections;
using System.Collections.Specialized;
using System.Collections.Generic;
using System.IO;
using System.Globalization;
using Data = Viddler.Data;

namespace Viddler.Resellers
{
  /// <summary>
  /// Provides access to Viddler API methods located in viddler.resellers namespace.
  /// </summary>
  /// <remarks>Visit <a href="http://developers.viddler.com/" target="_blank">http://developers.viddler.com/</a> to get the full overview of methods contained in this class.</remarks>
  public sealed class ResellersNamespaceWrapper : ViddlerNamespaceProvider
  {
    /// <summary>
    /// Initializes a new instance of ResellersNamespaceWrapper class.
    /// </summary>
    internal ResellersNamespaceWrapper(ViddlerService service) : base(service)
    {
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.resellers.getSubaccounts
    /// </summary>
    public Data.SubaccountList GetSubaccounts(int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Resellers.GetSubAccounts, Data.SubaccountList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.resellers.getSubaccounts
    /// </summary>
    public Data.SubaccountList GetSubaccounts()
    {
      return this.GetSubaccounts(null, null);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.resellers.removeSubaccounts
    /// </summary>
    public Data.SubaccountList RemoveSubaccounts(string subaccount, int? page, int? perPage)
    {
      StringDictionary parameters = new StringDictionary();
      parameters.Add("subaccount", subaccount);
      if (page.HasValue) parameters.Add("page", page.Value.ToString(CultureInfo.InvariantCulture));
      if (perPage.HasValue) parameters.Add("per_page", perPage.Value.ToString(CultureInfo.InvariantCulture));

      return this.Service.ExecuteHttpRequest<Resellers.RemoveSubaccounts, Data.SubaccountList>(parameters);
    }

    /// <summary>
    /// Calls the remote Viddler API method: viddler.resellers.removeSubaccounts
    /// </summary>
    public Data.SubaccountList RemoveSubaccounts(string subaccount)
    {
      return this.RemoveSubaccounts(subaccount, null, null);
    }
  }
}