FROM debian

RUN apt-get update
RUN apt-get install nodejs npm -y

WORKDIR /app

COPY . . 
ENV REACT_APP_API_KEY=92a85b30-ce60-3524-be59-84ff2f981773
RUN npm install

EXPOSE 3000

ENTRYPOINT ["npm", "start"]