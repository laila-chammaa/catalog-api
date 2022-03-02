run command to start up a mongodb instance in a docker container:
`docker run -d --rm --name mongo -p 27017:27017 -v mongodbdata:/data/db mongo`
