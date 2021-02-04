package com.example.flutterapi;

import org.springframework.web.filter.ServletContextRequestLoggingFilter;

public class Greeting {

    private final long id;
    private final String content;

    public Greeting(long id, String content) {
        this.id = id;
        this.content = content;
    }

    public long GetId() {
        return id;
    }

    public String getContent() {
        return content;
    }
}
