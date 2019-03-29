# Override web.config sections with environment variables
Most of the heavy lifting is done in [the configuration builder](Solid.Containers.Configuration/EnvironmentConfigurationBuilder.cs) with some configuration being done in the web.config.

## Try it out
First, try running the WebSite project normally in Visual Studio. You can check out the configuration and try changing some values in the custom configuration section (&lt;website&gt;...&lt;/website&gt;). You'll see information being put in the footer, external links being put in the navbar, and the name of the application changing.

Now run it in docker

    $ docker build --rm -t solid/docker-demo-site -f WebSite/Dockerfile .
    $ docker run -d --rm -p 8080:80 `
      -e ASPNET__website__name='Dockerized' `
      -e ASPNET__website__container__name='solid/docker-demo-site' `
      -e ASPNET__website__externalLinks__link[1]__name='Solid softworks' `
      -e ASPNET__website__externalLinks__link[1]__url='https//solidsoft.works' `
      solid/docker-demo-site

## Read more
We [blogged](https://solidsoft.works/2019/03/29/substituting-custom-web-config-sections-with-environment-variables-for-docker/) about this.
