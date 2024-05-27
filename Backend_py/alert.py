import smtplib
import os
import ssl
from email.message import EmailMessage


def email_alert(subject, body, to):
    msg = EmailMessage()
    msg.set_content(body)
    msg['subject'] = subject
    msg['to'] = to

    user = "smarthealthjewelry@gmail.com"
    msg['from'] = user
    password = "dvnz ufel zien mfvo"
    
    server = smtplib.SMTP("smtp.gmail.com",587)
    server.starttls()
    server.login(user,password)
    server.send_message(msg)
    server.quit()
    

def sms_alert(body,to):
    msg = EmailMessage()
    msg.set_content(body)
    msg['to'] = to

    user = "smarthealthjewelry@gmail.com"
    msg['from'] = user
    password = "dvnz ufel zien mfvo"

    server = smtplib.SMTP("smtp.gmail.com",587)
    server.starttls()
    server.login(user,password)
    server.send_message(msg)
    server.quit()

#if __name__ == '__main__':
    #sms_alert("Your patient's life is in danger","+4917630548044@t-d1-sms.de")
email_alert("Warning","Your patient's life is in danger","eduard.wegele1511@gmail.com")