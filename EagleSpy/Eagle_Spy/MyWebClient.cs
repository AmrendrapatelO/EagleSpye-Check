using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Eagle_Spy
{
	// Token: 0x02000080 RID: 128
	public class MyWebClient : WebClient
	{
		// Token: 0x06000748 RID: 1864 RVA: 0x000BF0D0 File Offset: 0x000BD2D0
		protected override WebRequest GetWebRequest(Uri address)
		{
			WebRequest webRequest = base.GetWebRequest(address);
			if (webRequest is HttpWebRequest)
			{
				HttpWebRequest httpWebRequest = (HttpWebRequest)webRequest;
				httpWebRequest.ClientCertificates.Add(new X509Certificate());
			}
			return webRequest;
		}
	}
}
