package entity;

public class ChatMessage {

    private String message;
    private ChatUser author;
    private long timestamp;
    private long sec = 60; // было 30 секунд это задание 4
    private long quantity = 15; // это вроде задание 3
    private String badWords ="Сука,сука,Блядь,блядь,Блять,блять,Бля,бля,Ебать,ебать,Нахуй,нахуй";
    private String HTMLtegs ="<a>,<p>,<body>,<html>,<head>,<div>";
    String[] ErrorWords=badWords.split(",");
    String[] ErrorHTML = HTMLtegs.split(",");


    public ChatMessage(String message, ChatUser author, long timestamp) {
        message = Smile(message);
        message = BedWordsFilter(message);
        message = HTMLFilter(message);
        this.message = message;
        this.author = author;
        this.timestamp = timestamp;
    }
    private String HTMLFilter(String message)
    {
        for (int i =0;i< ErrorHTML.length;i++)
        {
            message=message.replace(ErrorHTML[i],"");
        }
        return message;
    }
    private String BedWordsFilter(String message)
    {
        for (int i =0;i< ErrorWords.length;i++)
        {
            message=message.replace(ErrorWords[i],"*Тут был мат*");
        }
        return message;
    }
    private String Smile(String message)
    {
        message = message.replace(":("," [;(] ");
        message = message.replace(":)"," [;)] ");

        return message;
    }
    public long getQuantity()
    {return quantity;}

    public long getTimestamp() {
        return timestamp;
    }

    public void setTimestamp(long timestamp) {
        this.timestamp = timestamp;
    }

    public String getMessage() {
        return message;
    }

    public void setMessage(String message) {
        this.message = message;
    }

    public ChatUser getAuthor() {
        return author;
    }

    public void setAuthor(ChatUser author) {
        this.author = author;
    }

    public long getSec()
    {
        return sec;
    }

}
