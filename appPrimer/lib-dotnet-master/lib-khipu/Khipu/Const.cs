using System;

namespace Khipu.Api
{
	public class Const
	{
		public Const ()
		{
		}
		public static string CERT_PROD = @"-----BEGIN CERTIFICATE-----
			MIIFuDCCBSGgAwIBAgIQHCWU8WfzVpZq9iYPMgYpVzANBgkqhkiG9w0BAQUFADCB
			0DEUMBIGA1UEChMLRS1TaWduIFMuQS4xHzAdBgNVBAsTFlZlcmlTaWduIFRydXN0
			IE5ldHdvcmsxODA2BgNVBAsTL1Rlcm1zIG9mIHVzZSBhdCBodHRwczovL3d3dy5l
			LXNpZ24uY2wvcnBhIChjKTA1MTwwOgYDVQQDEzNFLVNpZ24gU0MgQ2xhc3MgMiBD
			b25zdW1lciBJbmRpdmlkdWFsIFN1YnNjcmliZXIgQ0ExHzAdBgkqhkiG9w0BCQEW
			EGUtc2lnbkBlLXNpZ24uY2wwHhcNMTIxMTA3MDAwMDAwWhcNMTMxMTA3MjM1OTU5
			WjCCAQgxMDAuBgNVBAsTJ1Rlcm1zIG9mIHVzZSBhdCB3d3cuZS1zaWduLmNsL3Jw
			YSBDKDA0KTElMCMGA1UECxMcQXV0aGVudGljYXRlZCBieSBFLVNpZ24gUy5BLjEn
			MCUGA1UECxMeTWVtYmVyLCBWZXJpU2lnbiBUcnVzdCBOZXR3b3JrMRswGQYDVQQL
			ExJEaWdpdGFsIElEIENsYXNzIDIxGDAWBgNVBAsUD1JVVCAtIDkxMjM4NDUtNDEl
			MCMGA1UEAxMcUm9iZXJ0byBBbmRyZXMgT3Bhem8gR2F6bXVyaTEmMCQGCSqGSIb3
			DQEJARYXcm9iZXJ0by5vcGF6b0BraGlwdS5jb20wggEiMA0GCSqGSIb3DQEBAQUA
			A4IBDwAwggEKAoIBAQC4xI/f6C/5V/KsIAQY3G2ExoqIb8NoM7czRw9UNdx/OEiL
			QJfqJjx1gVkcZxHqcWT6DENuf7H2LyYvzXOfeQgN5Zw8FCdIxjoF00AOIf3YDLdG
			0IXoiRuZWPh9JkbGyl/tSd/fJWSh12GQAUE0m0YYMNHGiNPqiZ3jJEUgNWKjfO2D
			xMqTGrujDnA3qF/2SiBrWRj5XyZCIYumrHWKGQnvmd6uaH4SOyaPc1Jl8byqfzg6
			GlHX2hWyVJ2Tc+GHxAiSm8RzUfSAfgCbUm+/8gX0uDlGA7dqaa9FIZh7RWBdN4Nn
			Dd9XHEOtXnBVL6mFzut57eAwEHz+a6tv2E2yy/GJAgMBAAGjggHSMIIBzjAiBgNV
			HREEGzAZoBcGCCsGAQQBwQEBoAsWCTkxMjM4NDUtNDAJBgNVHRMEAjAAMAsGA1Ud
			DwQEAwIFoDCBmQYDVR0gBIGRMIGOMIGLBgtghkgBhvhFAQcXAjB8MDEGCCsGAQUF
			BwIBFiVodHRwczovL3d3dy5lLXNpZ24uY2wvcmVwb3NpdG9yaW8uaHRtMEcGCCsG
			AQUFBwICMDsaOUNlcnRpZmljYWRvIHBhcmEgdXNvIFRyaWJ1dGFyaW8sIENvbWVy
			Y2lvLCBQYWdvcyB5IE90cm9zLjAjBgNVHRIEHDAaoBgGCCsGAQQBwQECoAwWCjk5
			NTUxNzQwLUswTQYDVR0fBEYwRDBCoECgPoY8aHR0cDovL29uc2l0ZWNybC52ZXJp
			c2lnbi5jb20vRVNpZ25TQUNTQ0NsYXNzMi9MYXRlc3RDUkwuY3JsMDsGCCsGAQUF
			BwEBBC8wLTArBggrBgEFBQcwAYYfaHR0cDovL29uc2l0ZS1vY3NwLnZlcmlzaWdu
			LmNvbTAdBgNVHSUEFjAUBggrBgEFBQcDAgYIKwYBBQUHAwQwEQYJYIZIAYb4QgEB
			BAQDAgeAMBEGCmCGSAGG+EUBBgkEAwEB/zANBgkqhkiG9w0BAQUFAAOBgQAFiXQz
			K9TrKWkJH3is2H/QI8gynHQV71kvmSUnRgPk5TdXzd6EDhbaQMC3pCdwhpKKUfFo
			0Ky8wtkagE8jdCRkpDfGpnhINfJZW9HH3gKe2zFckynPZcV5fsVM1tQzWQNBPaFf
			scJQlyZrC17dCDWkJ2op67BRjp97skB1SUWtRw==
			-----END CERTIFICATE-----}";
		public static string CERT_DEV = @"-----BEGIN CERTIFICATE-----
			MIIDszCCApsCBFA88VcwDQYJKoZIhvcNAQEFBQAwgZ0xIDAeBgkqhkiG9w0BCQEW
			EXJvYmVydG9Acm9wYXpvLmNsMQswCQYDVQQGEwJDTDERMA8GA1UECAwIU2FudGlh
			Z28xCzAJBgNVBAcMAlJNMRIwEAYDVQQKDAlLaGlwdS5jb20xGDAWBgNVBAsMD0dl
			cmVudGUgR2VuZXJhbDEeMBwGA1UEAwwVUm9iZXJ0byBPcGF6byBHYXptdXJpMB4X
			DTEyMDgyODE2MjcwM1oXDTEzMDgyODE2MjcwM1owgZ0xIDAeBgkqhkiG9w0BCQEW
			EXJvYmVydG9Acm9wYXpvLmNsMQswCQYDVQQGEwJDTDERMA8GA1UECAwIU2FudGlh
			Z28xCzAJBgNVBAcMAlJNMRIwEAYDVQQKDAlLaGlwdS5jb20xGDAWBgNVBAsMD0dl
			cmVudGUgR2VuZXJhbDEeMBwGA1UEAwwVUm9iZXJ0byBPcGF6byBHYXptdXJpMIIB
			IjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAk+0IYrfbAPSRSX8u3+js786J
			QTMXGS52LUFHOKXokQbqfcbPs9qwBDr4NeRbM3GQ8CRLLM9PKenHbd93ErpY4GDC
			CWZPU9RA4nFgJa/pJzFEf74dR0tQOnEdEDwCdlAp7EkVFIUnweSDG0QG9Dedvn/J
			tlHMRM0NXQSq6NxFPzjTyK4/J5g86V9LPEt6h+TpQACKxGxKa9cDdt6n8wDhskwV
			V6xiwkq+j+tNh5+DIdKstceG8UulgdpgTt9r7kr9FVwL1L3ugJ4zK1fGYbTwPQRu
			H9C0y7vZ/Mjm/osv9BAm0r57ywVgPU6af2yrTMhMkuCkMrIq4qW0XDiCTiso8QID
			AQABMA0GCSqGSIb3DQEBBQUAA4IBAQCO6do2tYvE5/nLYnPXQbpUhhJLvZbJd+Nl
			jLUlju2yzgNLFA3g19t9uKxKRG497//WdxHoa3lAPnY8IO+DgKp5dOMcKLopz+AX
			jsElzCQxcPNqlYwGQgEDDm9q0WXs1Dg22y0Af1oR5Lx9XR1xWsw4z/6YEDUJRa7D
			fAUIip+ocbMykuUvnrNU/wUDRv8VbsIoMr+1CK3pKACSUuB8ZhYfRUjgHEXKh4O5
			I/hKy49jGW/9i5GOTEGGzOvHm2CIrpBPFWfKSJLjvLtYWbBuCyKK5+FsP4wuN8Rv
			yLM1MDg00bd5M5MmTA1FFNGiGUqpfo7z+kcqRFOJqWm7bmaDvZVJ
			-----END CERTIFICATE-----";
	}
}

