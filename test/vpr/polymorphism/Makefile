# VRJ.NET is (C) Copyright 2004 by Patrick Hartling
# Distributed under the GNU Lesser General Public License 2.1.  (See
# accompanying file COPYING.txt or http://www.gnu.org/copyleft/lesser.txt)

default: all

CXX=		c++ -g
CSC=		mcs /debug
LD=		c++ -g -shared

CXXFLAGS=	$(shell vpr-config --cxxflags)
LIBDIR=		$(VRJNET_BASE_DIR)/lib
LDFLAGS=	$(shell vpr-config --libs) $(shell vpr-config --extra-libs)
DSO_NAME=	handle_obj
EXE_NAME=	tester
EXE_DEPS=	/r:$(LIBDIR)/vprnet.dll

CXX_SRCS=	handle_obj.cpp
CS_SRCS=	tester.cs

CXX_OBJS=	$(CXX_SRCS:.cpp=.o)

DSO=		lib$(DSO_NAME).so
EXE=		$(EXE_NAME).exe

%.o: %.cpp
	$(CXX) -Wall -W $(CXXFLAGS) $(INCUDES) -c $<

all: $(DSO) $(EXE)

$(DSO): $(CXX_OBJS)
	$(LD) -o $@ $(CXX_OBJS) $(LDFLAGS)

$(EXE): $(CS_SRCS)
	$(CSC) $(CS_SRCS) $(EXE_DEPS)

clean:
	rm -f $(CXX_OBJS)

clobber:
	rm -f $(DSO) $(EXE)
