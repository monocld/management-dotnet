namespace MonoCloud.Management.Clients;

/// <summary>
/// Represents a collection of functions to interact with the Options Api endpoints
/// </summary>
public class OptionsClient : MonoCloudClientBase
{
  /// <summary>
  /// Initializes a new instance of the <see cref="OptionsClient"/> class.
  /// </summary>
  /// <param name="configuration">The <see cref="MonoCloudConfig">MonoCloud Configuration</see></param>
  /// <returns></returns>
  public OptionsClient(MonoCloudConfig configuration) : base(configuration)
  {
  }

  /// <summary>
  /// Initializes a new instance of the <see cref="OptionsClient"/> class.
  /// </summary>
  /// <param name="httpClient">The <see cref="HttpClient"/> which will be used to communicate with the MonoCloud Api</param>
  /// <returns></returns>
  public OptionsClient(HttpClient httpClient) : base(httpClient)
  {
  }

  /// <summary>
  /// Retrieve authentication options
  /// </summary>
  /// <remarks>
  /// Retrieves the current authentication configuration, including enabled authenticators, sign-in and sign-up behavior, and external identity provider settings.
  /// </remarks>>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>AuthenticationOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<AuthenticationOptions>> FindAuthenticationOptionsAsync(CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/authentication?");

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

    return ProcessRequestAsync<AuthenticationOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Update authentication options
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the authentication configuration, including internal and external authenticators, sign-in behavior, and provider-specific settings. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="patchAuthenticationOptionsRequest">The request payload used to update the authentication options.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>AuthenticationOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<AuthenticationOptions>> PatchAuthenticationOptionsAsync(PatchAuthenticationOptionsRequest patchAuthenticationOptionsRequest, CancellationToken cancellationToken = default)
  {
    if (patchAuthenticationOptionsRequest == null)
    {
      throw new ArgumentNullException(nameof(patchAuthenticationOptionsRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/authentication?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchAuthenticationOptionsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<AuthenticationOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve communication options
  /// </summary>
  /// <remarks>
  /// Retrieves the current email and SMS delivery configuration.
  /// </remarks>>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>CommunicationOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<CommunicationOptions>> FindCommunicationOptionsAsync(CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/communication?");

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

    return ProcessRequestAsync<CommunicationOptions>(request, cancellationToken);
  }

  /// <summary>
  /// Update communication options
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the email and SMS delivery configuration. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="patchCommunicationOptionsRequest">The request payload used to update the communication options.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>CommunicationOptions</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<CommunicationOptions>> PatchCommunicationOptionsAsync(PatchCommunicationOptionsRequest patchCommunicationOptionsRequest, CancellationToken cancellationToken = default)
  {
    if (patchCommunicationOptionsRequest == null)
    {
      throw new ArgumentNullException(nameof(patchCommunicationOptionsRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/communication?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchCommunicationOptionsRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<CommunicationOptions>(request, cancellationToken);
  }

  /// <summary>
  /// List sign-up custom fields
  /// </summary>
  /// <remarks>
  /// Retrieves a list of configured custom fields collected during user sign-up.
  /// </remarks>>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;SignUpCustomField&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<SignUpCustomField>>> GetAllSignUpCustomFieldsAsync(CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/authentication/signup/custom_fields?");

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

    return ProcessRequestAsync<List<SignUpCustomField>>(request, cancellationToken);
  }

  /// <summary>
  /// Create a sign-up custom field
  /// </summary>
  /// <remarks>
  /// Creates a new custom field to be collected during user sign-up.
  /// </remarks>>
  /// <param name="createSignUpCustomFieldRequest">The request payload used to create a sign-up custom field configuration.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>SignUpCustomField</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<SignUpCustomField>> CreateSignUpCustomFieldAsync(CreateSignUpCustomFieldRequest createSignUpCustomFieldRequest, CancellationToken cancellationToken = default)
  {
    if (createSignUpCustomFieldRequest == null)
    {
      throw new ArgumentNullException(nameof(createSignUpCustomFieldRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/authentication/signup/custom_fields?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createSignUpCustomFieldRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<SignUpCustomField>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve a sign-up custom field
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified sign-up custom field.
  /// </remarks>>
  /// <param name="claimName">The unique claim name identifying the custom field.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>SignUpCustomField</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<SignUpCustomField>> FindSignUpCustomFieldAsync(string claimName, CancellationToken cancellationToken = default)
  {
    if (claimName == null)
    {
      throw new ArgumentNullException(nameof(claimName));
    }

    var encodedClaimName = HttpUtility.UrlEncode(claimName);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"options/authentication/signup/custom_fields/{encodedClaimName}?");

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

    return ProcessRequestAsync<SignUpCustomField>(request, cancellationToken);
  }

  /// <summary>
  /// Update a sign-up custom field
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified sign-up custom field configuration. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="claimName">The unique claim name identifying the custom field.</param>
  /// <param name="patchSignUpCustomFieldRequest">The request payload used to update the field configuration.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>SignUpCustomField</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<SignUpCustomField>> PatchSignUpCustomFieldAsync(string claimName, PatchSignUpCustomFieldRequest patchSignUpCustomFieldRequest, CancellationToken cancellationToken = default)
  {
    if (claimName == null)
    {
      throw new ArgumentNullException(nameof(claimName));
    }

    if (patchSignUpCustomFieldRequest == null)
    {
      throw new ArgumentNullException(nameof(patchSignUpCustomFieldRequest));
    }

    var encodedClaimName = HttpUtility.UrlEncode(claimName);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"options/authentication/signup/custom_fields/{encodedClaimName}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchSignUpCustomFieldRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<SignUpCustomField>(request, cancellationToken);
  }

  /// <summary>
  /// Delete a sign-up custom field
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified sign-up custom field configuration.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="claimName">The unique claim name identifying the custom field.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteSignUpCustomFieldAsync(string claimName, CancellationToken cancellationToken = default)
  {
    if (claimName == null)
    {
      throw new ArgumentNullException(nameof(claimName));
    }

    var encodedClaimName = HttpUtility.UrlEncode(claimName);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"options/authentication/signup/custom_fields/{encodedClaimName}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }

  /// <summary>
  /// List external authenticators
  /// </summary>
  /// <remarks>
  /// Retrieves the list of configured external authenticators.
  /// </remarks>>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>List&lt;ExternalAuthenticator&gt;</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<List<ExternalAuthenticator>>> GetAllExternalAuthenticatorsAsync(CancellationToken cancellationToken = default)
  {
    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/authentication/external?");

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

    return ProcessRequestAsync<List<ExternalAuthenticator>>(request, cancellationToken);
  }

  /// <summary>
  /// Configure an external authenticator
  /// </summary>
  /// <remarks>
  /// Configures a new external authenticator that end-users can authenticate with.
  /// </remarks>>
  /// <param name="createExternalAuthenticatorRequest">The request payload used to configure the external authenticator.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ExternalAuthenticator</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ExternalAuthenticator>> CreateExternalAuthenticatorAsync(CreateExternalAuthenticatorRequest createExternalAuthenticatorRequest, CancellationToken cancellationToken = default)
  {
    if (createExternalAuthenticatorRequest == null)
    {
      throw new ArgumentNullException(nameof(createExternalAuthenticatorRequest));
    }

    var urlBuilder = new StringBuilder();
    urlBuilder.Append("options/authentication/external?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("POST"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(createExternalAuthenticatorRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ExternalAuthenticator>(request, cancellationToken);
  }

  /// <summary>
  /// Retrieve an external authenticator
  /// </summary>
  /// <remarks>
  /// Retrieves detailed information for the specified external authenticator.
  /// </remarks>>
  /// <param name="name">The name of the external authenticator.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ExternalAuthenticator</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ExternalAuthenticator>> FindExternalAuthenticatorAsync(string name, CancellationToken cancellationToken = default)
  {
    if (name == null)
    {
      throw new ArgumentNullException(nameof(name));
    }

    var encodedName = HttpUtility.UrlEncode(name);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"options/authentication/external/{encodedName}?");

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

    return ProcessRequestAsync<ExternalAuthenticator>(request, cancellationToken);
  }

  /// <summary>
  /// Update an external authenticator
  /// </summary>
  /// <remarks>
  /// Applies a partial update to the specified external authenticator. Only fields included in the request are updated.
  /// </remarks>>
  /// <param name="name">The name of the external authenticator.</param>
  /// <param name="patchExternalAuthenticatorRequest">The request payload used to update the external authenticator.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns>ExternalAuthenticator</returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse<ExternalAuthenticator>> PatchExternalAuthenticatorAsync(string name, PatchExternalAuthenticatorRequest patchExternalAuthenticatorRequest, CancellationToken cancellationToken = default)
  {
    if (name == null)
    {
      throw new ArgumentNullException(nameof(name));
    }

    if (patchExternalAuthenticatorRequest == null)
    {
      throw new ArgumentNullException(nameof(patchExternalAuthenticatorRequest));
    }

    var encodedName = HttpUtility.UrlEncode(name);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"options/authentication/external/{encodedName}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("PATCH"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
      Content = new StringContent(Serialize(patchExternalAuthenticatorRequest), Encoding.UTF8, "application/json"),
      Headers =
      {
        { "Accept", "application/json" }
      }
    };

    return ProcessRequestAsync<ExternalAuthenticator>(request, cancellationToken);
  }

  /// <summary>
  /// Delete an external authenticator
  /// </summary>
  /// <remarks>
  /// Permanently deletes the specified external authenticator.
  /// </remarks>>
  /// <warning>This operation is irreversible.</warning>
  /// <param name="name">The name of the external authenticator.</param>
  /// <param name="cancellationToken">The <see cref="CancellationToken"/> used to propagate notifications that the operation should be canceled.</param>
  /// <returns></returns>
  /// <exception cref="MonoCloudException">A server side error occurred.</exception>
  public Task<MonoCloudResponse> DeleteExternalAuthenticatorAsync(string name, CancellationToken cancellationToken = default)
  {
    if (name == null)
    {
      throw new ArgumentNullException(nameof(name));
    }

    var encodedName = HttpUtility.UrlEncode(name);

    var urlBuilder = new StringBuilder();
    urlBuilder.Append($"options/authentication/external/{encodedName}?");

    urlBuilder.Length--;

    var request = new HttpRequestMessage
    {
      Method = new HttpMethod("DELETE"),
      RequestUri = new Uri(urlBuilder.ToString(), UriKind.RelativeOrAbsolute),
    };

    return ProcessRequestAsync(request, cancellationToken);
  }
}

