FROM debian

RUN apt-get update
RUN apt-get install nodejs npm -y

WORKDIR /app

COPY . . 

RUN npm install

EXPOSE 3000

ENTRYPOINT ["npm", "start"]