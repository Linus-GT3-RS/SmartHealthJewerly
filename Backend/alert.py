import smtplib
import os
import ssl

from email.message import EmailMessage

# notifiaction connection to email and sms

# send an alert email to contacts of a profile
def email_alert(topic, body, to):
    msg = EmailMessage()
    msg.set_content(body)
    msg['subject'] = topic
    msg['to'] = to

    # gmail account logging data
    user = "smarthealthjewelry@gmail.com"
    msg['from'] = user
    password = "dvnz ufel zien mfvo" #app password

    # start server connection
    server = smtplib.SMTP("smtp.gmail.com",587)
    server.starttls()

    # login
    server.login(user,password)

    #send message
    server.send_message(msg)

    server.quit()
    

# send an alert sms to contact of a profile
def sms_alert(body,to):
    msg = EmailMessage()
    msg.set_content(body)
    msg['to'] = to

    # gmail account logging data
    user = "smarthealthjewelry@gmail.com"
    msg['from'] = user
    password = "dvnz ufel zien mfvo"

    #start server connection
    server = smtplib.SMTP("smtp.gmail.com",587)
    server.starttls()

    #login
    server.login(user,password)

    #send message
    server.send_message(msg)

    server.quit()

# logic of calling function above
#if __name__ == '__main__':

    #sms_alert("Your patient's life is in danger","+4917630548044@t-d1-sms.de")

email_alert("Warning","Your patient's life is in danger","eduard.wegele1511@gmail.com")