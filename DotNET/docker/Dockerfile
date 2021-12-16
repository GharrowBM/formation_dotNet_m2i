FROM debian
RUN apt-get update
RUN apt-get install git -y 

WORKDIR /app

COPY fichier.txt .
COPY fichier2.txt .

EXPOSE 80

ENTRYPOINT ["cat", "fichier.txt"]

