# CurseForge ApiProxy

This project is meant to run behind a reverse proxy, and serves as a proxy server that 3rd party developers can host themselves, to enable them to hide their API key from the public.

Default port is `36000` (3 = C, 6 = F)

Port can be customized by setting an environment variable (`CFPROXY_PORT`) to another port number

The CF Core API Key is set in the environment variable `CFPROXY_APIKEY`.

## Terms of Services (important)

Depending on what type of key you've signed up for, there are two different terms of agreements/terms of services that you accepted.

For the unique application key, these are the ToS/ToC in regards for that key: [CurseForge 3rd Party API Terms and Conditions](https://support.curseforge.com/en/support/solutions/articles/9000207405-curse-forge-3rd-party-api-terms-and-conditions)

And if you have a personal API key, then these are the ToS/ToC: [CF Core Terms of Use](https://docs.curseforge.com/#terms-of-use)

### I have the Unique Application Key, can I use this?

No, don't use this project, as this breaks the [ToS (section 3)[https://support.curseforge.com/en/support/solutions/articles/9000207405-curse-forge-3rd-party-api-terms-and-conditions#Restrictions-and-Obligations-of-Developer)

> Developer shall not, and shall not allow any third party, to (a) copy, sublicense, adapt, modify the Platform, Platform API and/or any SDK; (b) rent, lease, modify, copy, loan, transfer, sublicense, distribute or create derivative works of the Platform, Platform API and/or any SDK; (c) disassemble, reverse engineer, attempt to find the underlying code of, or decompile the Platform, Platform API and/or any SDK; (d) circumvent any security mechanisms of the Platform, Platform API and/or any SDK; or (d) remove or obscure any copyright or other notices from the Platform, Platform API and/or any SDK, (e) conceal your identity or geographic location when accessing the API, **including accessing the API through a proxy server or VPN**;  or (e) save or cache any data obtained through the API or SDK.

So, specifically the part `including accessing the API through a proxy server or VPN` is the part that does not allow you to use the API through a proxy or VPN.

### I have my personal API key from the console, can I use this?

Personally, I'd say no, but currently (as of 2022-04-25), there is nothing in the [CF Core Terms of Use](https://docs.curseforge.com/#terms-of-use) that says you can't do it.

But essentially, yes, you can use this, on your own risk.

## How to use this project

First of all, you need to compile the code (I will not provide executables for this, as this is already sketchy territory as it is).
And depending on if you're going to host it on Windows or Linux, you'll have to figure out how to run it as a service or through IIS.

The project is open source, and provided as-is.

## Terms of Use

By using this piece of software (in it's original form, found in the CurseForgeCommunity organization), I agree to the applicable Terms of Use/Conditions/Service that my API key for the CurseForge Core API, and will not hold the developer of this proxy liable to any issues I might encounter for using it the wrong way.
