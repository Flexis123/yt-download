from pytube import YouTube
import os
import sys

url = 'https://www.youtube.com/watch?v=cST5TT3OFyg&t=28s'
path = os.curdir

def downloadYouTube(videourl, path):
    try:
        yt = YouTube(videourl)
        yt = yt.streams.filter(progressive=True, file_extension='mp4').order_by('resolution').desc().first()
        if not os.path.exists(path):
            os.makedirs(path)
        yt.download(path)
        print('url downloaded')
        n = input()
    except:
        print('unvalid url')
        
downloadYouTube(url,path)
