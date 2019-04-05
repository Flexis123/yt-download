from pytube import YouTube
import os
import sys


def download(videourl, path):
    path = os.curdir
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
        

