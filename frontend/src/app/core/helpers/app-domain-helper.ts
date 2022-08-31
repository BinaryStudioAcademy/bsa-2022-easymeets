export const getAppDomain = (): string => {
    const split = document.location.href.split('/');

    return `${split[0]}//${split[2]}/`;
};
