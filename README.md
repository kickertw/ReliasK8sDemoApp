
# Relias K8s Demo App

## Summary

This project contains 2 dotnet core apps that are able to be containerize and run in a k8s cluster. I am currently only able to get both apps talking when deployed in AWS EKS or Azure AKS. Locally w/ minikube or docker for windows there are some DNS issues and both will run, but not be able to talk to one another

## The Guts
|File/Directory|Description  |
|--|--|
|./k8s-templates|2 K8s templates for the deployment of the web + api apps. 2 K8s templates for an internal and external load balancer.  |
|./ReliasK8sFrontEnd|Dotnet core razor web app. The index page should show an animated gif|
|./ReliasK8sApi|Dotnet core webAPI app. The main endpoint "/api/gif" will return a randomized gif URL. Also has a healthcheck page returning 🌮🌮🌮|

  
## How did I get this thing to work 🤷‍
*(Note: I ran this on Windows 10 Pro w/ powershell)*
 - Clone the repo (duh)
 - Install [Docker Desktop](https://hub.docker.com/editions/community/docker-ce-desktop-windows/). Also make sure your OS has HyperV enabled. Docker Desktop should not only install docker and the docker cli, but also kubectl. Also make sure Docker Desktop has Kubernetes enabled via the settings menu.
 - Containerize the API and push to Docker Hub:
	 - From ***./ReliasK8sApi***, run the following commands
	 - `docker build -t <your-docker-hub-username>/<image-name> .`
	 - `docker push <your-docker-hub-username>/<image-name>`
- Containerize the web application and push to Docker Hub (Just do the same as above, but go to the appropriate directory and use a different image name (e.g. - k8s-demo-web).
- Deploy your apps to the local cluster.
  - From the root folder, run the following
  - `kubectl apply -f .\k8s-templates`