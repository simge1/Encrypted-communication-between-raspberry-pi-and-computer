import socket
import time

import mysql.connector
import MySQLdb
db=mysql.connector.connect(host='127.0.0.1',
                            db='users',
                            user='root',
                            password='securepassword')

db2=mysql.connector.connect(host='127.0.0.1',
                            db='users',
                            user='root',
                            password='securepassword')
                           
                        
baglanti=db.cursor()
baglanti.execute('SELECT * FROM user')
user=baglanti.fetchall()

baglanti2=db2.cursor()
baglanti2.execute('SELECT * FROM messages')
messages=baglanti2.fetchall()

#for receive
sock1=socket.socket(socket.AF_INET,socket.SOCK_STREAM)
host1="192.168.137.1"
port=1234
sock1.connect((host1,port))

sock2=socket.socket(socket.AF_INET,socket.SOCK_STREAM)
host2="192.168.137.2"
sock2.connect((host2,port))

sock3=socket.socket(socket.AF_INET,socket.SOCK_STREAM)
host3="192.168.137.50"
sock3.connect((host3,port))


    
#for sending

listensocket = socket.socket()
Port = 8000
maxConnections=999


IP = socket.gethostname()

listensocket.bind(('',Port))

listensocket.listen(maxConnections)
print("Server started at" + IP + " on port " + str(Port))
'''
(clientsocket,address) = listensocket.accept()
print("new connection made")

'''



running=True

global ID
global fromperson



    
while running:
    (clientsocket,address) = listensocket.accept()
    print("new connection made"+ str(address))
    
    
    if str(address[0])==('192.168.137.1'):
        username = clientsocket.recv(1024).decode()
        print(username)
        password = clientsocket.recv(1024).decode()
        print(password)
        for i in user:
            if i[1]==username and i[3]!=password:
                dataReceived="wrong"
                sock1.sendall(str.encode(dataReceived))
                print(dataReceived)
        
        
        
        for j in messages:
            if j[3]==username:
                msg=j[2]
                dataReceived=str(msg)
                fromperson=j[1]
                sock1.send(str.encode(dataReceived))
                print(dataReceived)
                
        for k in user:
            if k[0]==fromperson:
                msgfrm=k[1]
                dataReceived=str(msgfrm)
                sock1.send(str.encode(dataReceived))
                print("gönderen kişi: "+k[1])
        
        
        for i in user:
            if i[1]==username and i[3]==password: 
                ID=i[0]
                message = clientsocket.recv(1024).decode()
                input = (message,ID)
                baglanti2.execute('UPDATE messages SET message = %s WHERE id_user = %s',(input))
                db2.commit()
                towho = clientsocket.recv(1024).decode()
                input = (towho,ID)
                baglanti2.execute('UPDATE messages SET towho = %s WHERE id_user = %s',(input))
                db2.commit()
                
                
                
        
     
        
    if str(address[0])==('192.168.137.2'):
        username = clientsocket.recv(1024).decode()
        print(username)
        password = clientsocket.recv(1024).decode()
        print(password)
        for i in user:
            if i[1]==username and i[3]!=password:
                dataReceived="wrong"
                sock2.sendall(str.encode(dataReceived))
                print(dataReceived)
        
        
        
        for j in messages:
            if j[3]==username:
                msg=j[2]
                dataReceived=str(msg)
                fromperson=j[1]
                sock2.send(str.encode(dataReceived))
                print(dataReceived)
                
        for k in user:
            if k[0]==fromperson:
                msgfrm=k[1]
                dataReceived=str(msgfrm)
                sock2.send(str.encode(dataReceived))
                print("gönderen kişi: "+k[1]) 
                
        for i in user:
            
            if i[1]==username and i[3]==password: 
                ID=i[0]
                message = clientsocket.recv(1024).decode()
                input = (message,ID)
                baglanti2.execute('UPDATE messages SET message = %s WHERE id_user = %s',(input))
                db2.commit()
                towho = clientsocket.recv(1024).decode()
                input = (towho,ID)
                baglanti2.execute('UPDATE messages SET towho = %s WHERE id_user = %s',(input))
                db2.commit()
                
                
    if str(address[0])==('192.168.137.50'):
        username = clientsocket.recv(1024).decode()
        print(username)
        password = clientsocket.recv(1024).decode()
        print(password)
        for i in user:
            if i[1]==username and i[3]!=password:
                dataReceived="wrong"
                sock3.sendall(str.encode(dataReceived))
                print(dataReceived)
        
        
        
        for j in messages:
            if j[3]==username:
                msg=j[2]
                dataReceived=str(msg)
                fromperson=j[1]
                sock3.send(str.encode(dataReceived))
                print(dataReceived)
                
        for k in user:
            if k[0]==fromperson:
                msgfrm=k[1]
                dataReceived=str(msgfrm)
                sock3.send(str.encode(dataReceived))
                print("gönderen kişi: "+k[1]) 
                
        for i in user:
            
            if i[1]==username and i[3]==password: 
                ID=i[0]
                message = clientsocket.recv(1024).decode()
                input = (message,ID)
                baglanti2.execute('UPDATE messages SET message = %s WHERE id_user = %s',(input))
                db2.commit()
                towho = clientsocket.recv(1024).decode()
                input = (towho,ID)
                baglanti2.execute('UPDATE messages SET towho = %s WHERE id_user = %s',(input))
                db2.commit()
                        
   
   
   
   
        
                
                
                
        
          
        ###
    '''    
    (clientsocket,address) = listensocket.accept()
    print("new connection made")
        
    username = clientsocket.recv(1024).decode()
    print(username)
    password = clientsocket.recv(1024).decode()
    print(password)
    
    
    for i in user:
        if i[1]==username and i[3]==password:
             #value="available"
             #dataReceived=str(value)
             
             #sock.sendall(str.encode(dataReceived))
             #print(dataReceived)
             
             ID=i[0]
             message = clientsocket.recv(1024).decode()
             input = (message,ID)
             baglanti2.execute('UPDATE messages SET message = %s WHERE id_user = %s',(input))
             db2.commit()
             
             towho = clientsocket.recv(1024).decode()
             input = (towho,ID)
             baglanti2.execute('UPDATE messages SET towho = %s WHERE id_user = %s',(input))
             db2.commit()
        
            
    for j in messages:
        
        if j[3]==username:
            msg=j[2]
            dataReceived=str(msg)
            fromperson=j[1]
            if sock1.connect:
                sock1.sendall(str.encode(dataReceived))
                print(dataReceived)
                
            if sock2.connect:
                sock2.sendall(str.encode(dataReceived))
                print(dataReceived)
                
              
    for k in user:
        if k[0]==fromperson:
            msgfrm=k[1]
            dataReceived=str(msgfrm)
            if sock1.connect:
                sock1.sendall(str.encode(dataReceived))
                print("gönderen kişi: "+k[1])
            if sock2.connect:
                sock2.sendall(str.encode(dataReceived))
                print("gönderen kişi: "+k[1])

'''