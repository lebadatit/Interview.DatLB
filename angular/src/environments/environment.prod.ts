import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: true,
  application: {
    baseUrl,
    name: 'DatLB',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44338/',
    redirectUri: baseUrl,
    clientId: 'DatLB_App',
    responseType: 'code',
    scope: 'offline_access DatLB',
    requireHttps: true
  },
  apis: {
    default: {
      url: 'https://localhost:44338',
      rootNamespace: 'Interview.DatLB',
    },
  },
} as Environment;
