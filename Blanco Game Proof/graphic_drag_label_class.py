# -*- coding: utf-8 -*-
"""
Created on Tue Oct 14 11:21:51 2014

@author: Mija
"""

from PyQt4.QtGui import *
from PyQt4.QtCore import *

import resources

class QDragLabel(QLabel):
    """this class provides an image label that can be dragged and dropped"""
    #constructor
    def __init__(self,picture):
        super(QDragLabel,self).__init__()
        self.setPixmap(picture.scaledToWidth(35,1))
        self.mimetext = None
        
    def mouseMoveEvent(self,event):
        #if left mouse button is used
        if event.buttons()==Qt.LeftButton:
            data=QByteArray()
            mime_data = QMimeData()
            mime_data.setData(self.mimetext,data)
            drag = QDrag(self)
            drag.setMimeData(mime_data)
            drag.setHotSpot(self.rect().topLeft())#where do we drag from
            drop_action = drag.start(Qt.MoveAction)#drag starts
            
        
class WhiteCellDragLabel(QDragLabel):
    """this class provides a White Cell that can be dragged and dropped"""
    def __init__(self):
        super(WhiteCellDragLabel,self).__init__(QPixmap(":/white_cell.png"))
        self.mimetext = "application/x-white"

class BlueCellDragLabel(QDragLabel):
    """this class provides a White Cell that can be dragged and dropped"""
    def __init__(self):
        super(BlueCellDragLabel,self).__init__(QPixmap(":/blue_cell.png"))
        self.mimetext = "application/x-blue"

class YellowCellDragLabel(QDragLabel):
    """this class provides a White Cell that can be dragged and dropped"""
    def __init__(self):
        super(YellowCellDragLabel,self).__init__(QPixmap(":/yellow_cell.png"))
        self.mimetext = "application/x-yellow"

class RedCellDragLabel(QDragLabel):
    """this class provides a White Cell that can be dragged and dropped"""
    def __init__(self):
        super(RedCellDragLabel,self).__init__(QPixmap(":/red_cell.png"))
        self.mimetext = "application/x-red"

class GreenCellDragLabel(QDragLabel):
    """this class provides a White Cell that can be dragged and dropped"""
    def __init__(self):
        super(GreenCellDragLabel,self).__init__(QPixmap(":/green_cell.png"))
        self.mimetext = "application/x-green"
        
        
