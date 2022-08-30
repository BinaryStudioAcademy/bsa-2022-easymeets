export const getAppDomain = (): string => `https://${document.location.href.split('/')[2]}/`;
