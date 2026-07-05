namespace MonoCloud.Management.Clients;

/// <summary>
/// Represents a collection of functions to interact with the TrustStores Api endpoints
/// </summary>
public class TrustStoresClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="TrustStoresClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public TrustStoresClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="TrustStoresClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public TrustStoresClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// List PKI trust stores
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of PKI trust stores. Optional query parameters allow sorting of the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of trust stores to return per page.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;name&#x60;, &#x60;creation_time&#x60; and &#x60;last_updated&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;PkiTrustStoreSummary&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<PkiTrustStoreSummary>, PageModel>> GetAllPkiTrustStoresAsync(int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststores/pki?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<PkiTrustStoreSummary>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a PKI trust store
  /// </summary>
  /// <remarks>
  /// Creates a new PKI trust store used to manage trusted certificate authorities and certificate validation settings for mTLS authentication.
  /// </remarks>>
  /// <param name="createPkiTrustStoreRequest">The request payload used to create a trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>PkiTrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<PkiTrustStore>> CreatePkiTrustStoreAsync(CreatePkiTrustStoreRequest createPkiTrustStoreRequest, CancellationToken cancellationToken = default)
  {
    if (createPkiTrustStoreRequest == null)
    {
      throw new ArgumentNullException(nameof(createPkiTrustStoreRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststores/pki?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createPkiTrustStoreRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<PkiTrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a PKI trust store
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified PKI trust store.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>PkiTrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<PkiTrustStore>> FindPkiTrustStoreByIdAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<PkiTrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Update a PKI trust store
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified PKI trust store. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="patchPkiTrustStoreRequest">The request payload used to update a trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>PkiTrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<PkiTrustStore>> PatchPkiTrustStoreAsync(string trustStoreId, PatchPkiTrustStoreRequest patchPkiTrustStoreRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (patchPkiTrustStoreRequest == null)
    {
      throw new ArgumentNullException(nameof(patchPkiTrustStoreRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchPkiTrustStoreRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<PkiTrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a PKI trust store
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified PKI trust store.
  /// </remarks>>
  /// <warning>This operation is irreversible. Any client applications relying on this trust store for mTLS authentication will immediately fail certificate validation.</warning>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeletePkiTrustStoreAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Set a PKI trust store as the default
  /// </summary>
  /// <remarks>
  /// Marks the specified trust store as the default for mTLS authentication. This default is used when no explicit trust store is selected for an mTLS endpoint.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>PkiTrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<PkiTrustStore>> SetPkiTrustStoreDefaultAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}/default?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<PkiTrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// List certificate revocations
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of certificate revocations (offline CRLs) configured for the specified trust store. Optional query parameters allow sorting of the results.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of revocations to return per page.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;creation_time&#x60; and &#x60;issued_at&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;RevocationGrouped&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<RevocationGrouped>, PageModel>> GetAllRevocationsAsync(string trustStoreId, int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}/revocations?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<RevocationGrouped>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a certificate revocation
  /// </summary>
  /// <remarks>
  /// Uploads and registers an offline Certificate Revocation List (CRL) for the specified trust store. The CRL is used for offline revocation checking when the trust store is configured with `RevocationMode` set to `Offline`.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="addCertificateRevocationRequest">The request payload defining the certificate revocation list (CRL) to add to the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ICertificateRevocation</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ICertificateRevocation>> AddCertificateRevocationAsync(string trustStoreId, AddCertificateRevocationRequest addCertificateRevocationRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (addCertificateRevocationRequest == null)
    {
      throw new ArgumentNullException(nameof(addCertificateRevocationRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}/revocations?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(addCertificateRevocationRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ICertificateRevocation>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a certificate revocation
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified certificate revocation (CRL) within the trust store.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="revocationId">The unique identifier of the certificate revocation.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ICertificateRevocation</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ICertificateRevocation>> FindCertificateRevocationAsync(string trustStoreId, string revocationId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (revocationId == null)
    {
      throw new ArgumentNullException(nameof(revocationId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var encodedRevocationId = HttpUtility.UrlEncode(revocationId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}/revocations/{encodedRevocationId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ICertificateRevocation>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a certificate revocation
  /// </summary>
  /// <remarks>
  /// Permanently removes the specified certificate revocation (CRL) from the trust store.
  /// </remarks>>
  /// <warning>This operation is irreversible. Revocation checks will no longer include this CRL.</warning>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="revocationId">The unique identifier of the certificate revocation.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> RemoveCertificateRevocationAsync(string trustStoreId, string revocationId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (revocationId == null)
    {
      throw new ArgumentNullException(nameof(revocationId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var encodedRevocationId = HttpUtility.UrlEncode(revocationId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}/revocations/{encodedRevocationId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List PKI banned certificates
  /// </summary>
  /// <remarks>
  /// Retrieves the list of client certificates that are explicitly banned for the specified PKI trust store.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;BannedCertificate&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<BannedCertificate>>> GetAllPkiBannedCertificatesAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}/banned_certificates?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<BannedCertificate>>(request, cancellationToken);
  }

  /// <summary>
  /// Ban a PKI certificate
  /// </summary>
  /// <remarks>
  /// Creates a banned certificate entry in the specified PKI trust store, preventing certificates matching the provided identifier from being trusted during mTLS authentication.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="banTrustStoreCertificateRequest">The request payload used to ban a certificate.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>BannedCertificate</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<BannedCertificate>> BanPkiTrustStoreCertificateAsync(string trustStoreId, BanTrustStoreCertificateRequest banTrustStoreCertificateRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (banTrustStoreCertificateRequest == null)
    {
      throw new ArgumentNullException(nameof(banTrustStoreCertificateRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}/banned_certificates?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(banTrustStoreCertificateRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<BannedCertificate>(request, cancellationToken);
  }

  /// <summary>
  /// Unban a PKI certificate
  /// </summary>
  /// <remarks>
  /// Removes a banned-certificate entry from the trust store, allowing matching certificates to be trusted again.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="banId">The unique identifier of the banned certificate entry.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> UnbanPkiTrustStoreCertificateAsync(string trustStoreId, string banId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (banId == null)
    {
      throw new ArgumentNullException(nameof(banId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var encodedBanId = HttpUtility.UrlEncode(banId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/pki/{encodedTrustStoreId}/banned_certificates/{encodedBanId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List SPIFFE trust stores
  /// </summary>
  /// <remarks>
  /// Retrieves a paginated list of SPIFFE trust stores. Optional query parameters allow sorting of the results.
  /// </remarks>>
  /// <param name="page">The page number to retrieve.</param>
  /// <param name="size">The number of trust stores to return per page.</param>
  /// <param name="sort">Sort expression in the format &#x60;field:direction&#x60;, where direction is &#x60;1&#x60; for ascending or &#x60;-1&#x60; for descending. Supported fields include - &#x60;name&#x60;, &#x60;creation_time&#x60; and &#x60;last_updated&#x60;</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;SpiffeTrustStoreSummary&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<SpiffeTrustStoreSummary>, PageModel>> GetAllSpiffeTrustStoresAsync(int? page = 1, int? size = 10, string? sort = default, CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststores/spiffe?");

    if (page != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("page") + "=").Append(HttpUtility.UrlEncode(page.ToString())).Append("&");
    }

    if (size != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("size") + "=").Append(HttpUtility.UrlEncode(size.ToString())).Append("&");
    }

    if (sort != null)
    {
      urlBuilder.Append(Uri.EscapeDataString("sort") + "=").Append(HttpUtility.UrlEncode(sort)).Append("&");
    }

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<SpiffeTrustStoreSummary>, PageModel>(request, cancellationToken);
  }

  /// <summary>
  /// Create a SPIFFE trust store
  /// </summary>
  /// <remarks>
  /// Creates a new SPIFFE trust store for a federated SPIFFE trust domain and its workload identities.
  /// </remarks>>
  /// <param name="createSpiffeTrustStoreRequest">The request payload used to create a trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>SpiffeTrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<SpiffeTrustStore>> CreateSpiffeTrustStoreAsync(CreateSpiffeTrustStoreRequest createSpiffeTrustStoreRequest, CancellationToken cancellationToken = default)
  {
    if (createSpiffeTrustStoreRequest == null)
    {
      throw new ArgumentNullException(nameof(createSpiffeTrustStoreRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("truststores/spiffe?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createSpiffeTrustStoreRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<SpiffeTrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a SPIFFE trust store
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified SPIFFE trust store.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>SpiffeTrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<SpiffeTrustStore>> FindSpiffeTrustStoreByIdAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/spiffe/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<SpiffeTrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Update a SPIFFE trust store
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified SPIFFE trust store. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="patchSpiffeTrustStoreRequest">The request payload used to update a trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>SpiffeTrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<SpiffeTrustStore>> PatchSpiffeTrustStoreAsync(string trustStoreId, PatchSpiffeTrustStoreRequest patchSpiffeTrustStoreRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (patchSpiffeTrustStoreRequest == null)
    {
      throw new ArgumentNullException(nameof(patchSpiffeTrustStoreRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/spiffe/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchSpiffeTrustStoreRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<SpiffeTrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a SPIFFE trust store
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified SPIFFE trust store.
  /// </remarks>>
  /// <warning>This operation is irreversible. Any client applications relying on this trust store for authentication will immediately fail validation.</warning>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteSpiffeTrustStoreAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/spiffe/{encodedTrustStoreId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// Set a SPIFFE trust store as the default
  /// </summary>
  /// <remarks>
  /// Marks the specified trust store as the default for mTLS authentication. This default is used when no explicit trust store is selected for an mTLS endpoint.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>SpiffeTrustStore</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<SpiffeTrustStore>> SetSpiffeTrustStoreDefaultAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/spiffe/{encodedTrustStoreId}/default?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<SpiffeTrustStore>(request, cancellationToken);
  }

  /// <summary>
  /// List banned SVIDs
  /// </summary>
  /// <remarks>
  /// Retrieves the list of SVIDs that are explicitly banned for the specified SPIFFE trust store.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;BannedSvid&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<BannedSvid>>> GetAllSpiffeBannedSvidsAsync(string trustStoreId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/spiffe/{encodedTrustStoreId}/banned_svids?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("GET"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<List<BannedSvid>>(request, cancellationToken);
  }

  /// <summary>
  /// Ban a SVID
  /// </summary>
  /// <remarks>
  /// Creates a banned SVID entry in the specified SPIFFE trust store, preventing SVIDs matching the provided identifier from being trusted during authentication.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="banTrustStoreSvidRequest">The request payload used to ban a SVID.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>BannedSvid</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<BannedSvid>> BanSpiffeTrustStoreSvidAsync(string trustStoreId, BanTrustStoreSvidRequest banTrustStoreSvidRequest, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (banTrustStoreSvidRequest == null)
    {
      throw new ArgumentNullException(nameof(banTrustStoreSvidRequest));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/spiffe/{encodedTrustStoreId}/banned_svids?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(banTrustStoreSvidRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<BannedSvid>(request, cancellationToken);
  }

  /// <summary>
  /// Unban a SVID
  /// </summary>
  /// <remarks>
  /// Removes a banned-SVID entry from the trust store, allowing matching SVIDs to be trusted again.
  /// </remarks>>
  /// <param name="trustStoreId">The unique identifier of the trust store.</param>
  /// <param name="banId">The unique identifier of the banned SVID entry.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> UnbanSpiffeTrustStoreSvidAsync(string trustStoreId, string banId, CancellationToken cancellationToken = default)
  {
    if (trustStoreId == null)
    {
      throw new ArgumentNullException(nameof(trustStoreId));
    }

    if (banId == null)
    {
      throw new ArgumentNullException(nameof(banId));
    }

    var encodedTrustStoreId = HttpUtility.UrlEncode(trustStoreId);

    var encodedBanId = HttpUtility.UrlEncode(banId);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"truststores/spiffe/{encodedTrustStoreId}/banned_svids/{encodedBanId}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

