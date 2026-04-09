import { MsalGuardConfiguration, MsalInterceptorConfiguration } from '@azure/msal-angular';
import {
  BrowserCacheLocation,
  InteractionType,
  IPublicClientApplication,
  LogLevel,
  PublicClientApplication,
} from '@azure/msal-browser';

const ENTRA_TENANT_SUBDOMAIN = 'tgclogin';
const ENTRA_CLIENT_ID = 'a17a0476-1b03-41c9-bf4e-5c38da22dc5d';
const ENTRA_AUTHORITY_DOMAIN = `${ENTRA_TENANT_SUBDOMAIN}.ciamlogin.com`;
const ENTRA_AUTHORITY = `https://${ENTRA_AUTHORITY_DOMAIN}/`;

export function msalInstanceFactory(): IPublicClientApplication {
  return new PublicClientApplication({
    auth: {
      clientId: ENTRA_CLIENT_ID,
      authority: ENTRA_AUTHORITY,
      knownAuthorities: [ENTRA_AUTHORITY_DOMAIN],
      redirectUri: '/',
      postLogoutRedirectUri: '/',
    },
    cache: {
      cacheLocation: BrowserCacheLocation.LocalStorage,
    },
    system: {
      loggerOptions: {
        logLevel: LogLevel.Info,
        piiLoggingEnabled: false,
      },
    },
  });
}

export function msalGuardConfigFactory(): MsalGuardConfiguration {
  return {
    interactionType: InteractionType.Redirect,
    authRequest: {
      scopes: ['openid', 'profile'],
    },
    loginFailedRoute: '/',
  };
}

export function msalInterceptorConfigFactory(): MsalInterceptorConfiguration {
  return {
    interactionType: InteractionType.Redirect,
    protectedResourceMap: new Map([]),
  };
}
