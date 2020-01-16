// Java Code For Ranking Algorthim this should run on the computation server
// It broke when migrating to Azure
/* 
 
public class CVReader
{	
    
	
				   //------------------------------------------doc---------------------------------------------//
				      if(f.getName().endsWith(".doc")) 
				      {   filecount++;
				          WordExtractor extractor = null;
				          try
				          {   System.out.println("Opening CV : "+f.getName()+"(word format)\n");
				              foutput.write("\nOpening CV : "+f.getName()+"(word format)\n");
				              t3.append("\nOpening CV : "+f.getName()+"(word format)\n");
				              int count=0;
				          
				              FileInputStream fis = new FileInputStream(f.getAbsolutePath());
				              HWPFDocument document = new HWPFDocument(fis); 
				              extractor = new WordExtractor(document);
				 
				                  	  String lines[] = fileData;
					                  for (String line : lines) 
					                  {      
					         		     String check[] = {}; 
					         	         check=line.split(" ");  
					         	          for (String word : check) 
					         	          {
					         	                 for(String k:keyword) 
					         	                 {	 
					         	        	        if (word.equals(k))   
					         	                    {
					         	        	    	  System.out.print("Keyword '"+k+"' is found!\n");
					         	        	    	  foutput.write("Keyword '"+k+"' is found!\n");
					         	        	    	  t3.append("Keyword '"+k+"' is found!\n");
					         	                      count++;     
					         	                     
					         	                    }
					         	                 }
					         	          }
					         	         }   
				                 
				              System.out.println("Total keywords found / CV strength = "+count+"\n");
				              foutput.write("Total number of keywords found in "+f.getName()+" : "+count+"\n");
				              t3.append("Total number of keywords found in "+f.getName()+" : "+count+"\n");
				              if(count>comp) comp=count;
				              if(count==0)
				              {foutput.write("No keywords found in this CV.\n");
				              t3.append("No keywords found in this CV.\n");}
				              
				                  
				          }
				          catch (Exception exep)
				          {
				              exep.printStackTrace();
				          }  
				      }	 
				     //------------------------------------else for pdf---------------------------------------//
				      else if(f.getName().endsWith(".pdf"))
				      {   filecount++;
				    	  try (PDDocument document = PDDocument.load(f)) 
				          {   System.out.println("\nOpening CV : "+f.getName()+"(pdf format)\n");
				              foutput.write("\nOpening CV : "+f.getName()+"(pdf format)\n");
				              t3.append("\nOpening CV : "+f.getName()+"(pdf format)\n");
				              int count=0;
				          	
				              document.getClass();

				              if (!document.isEncrypted()) 
				              {
				                  PDFTextStripperByArea stripper = new PDFTextStripperByArea(); 
				                  stripper.setSortByPosition(true);

				                  PDFTextStripper tStripper = new PDFTextStripper();

				                  String pdfFileInText = tStripper.getText(document);

				  				
				                  String lines[] = pdfFileInText.split("\\r?\\n");
				                  for (String line : lines) 
				                  {      
				         		     String check[] = {}; 
				         	         check=line.split(" ");  
				         	          for (String word : check) 
				         	          {
				         	                 for(String k:keyword) 
				         	                 {	 
				         	        	        if (word.equals(k))   
				         	                    {
				         	        	    	  System.out.print("Keyword '"+k+"' is found!\n");  
				         	        	    	  foutput.write("Keyword '"+k+"' is found!\n");
				         	        	    	  t3.append("Keyword '"+k+"' is found!\n");
				         	                      count++;     
				         	                     
				         	                    }
				         	                 }
				         	          }
				         	         }	

				                 }
				              System.out.println("Total keywords found / CV strength = "+count+"\n");
				              foutput.write("Total number of keywords found in "+f.getName()+" : "+count+"\n");
				              t3.append("Total number of keywords found in "+f.getName()+" : "+count+"\n");
				              if(count>comp) comp=count;
				              if(count==0)
				              { foutput.write("No keywords found in this CV.\n");
				              t3.append("No keywords found in this CV.\n"); }
				              }
				      }
				      else
				      System.out.print("No doc/pdf files found in the specified directory");	
				    }	
					foutput.write("\nTotal number of files scanned : "+filecount);
					t3.append("\nTotal number of files scanned : "+filecount);
					foutput.write("\nHighest number of keywords found in a CV : "+comp);
					t3.append("\nHighest number of keywords found in a CV : "+comp);
					
					
					foutput.close();
	          }
	          catch(Exception ae){}
	          }});
		
		System.out.print("Enter keywords you want to search, seperated by a space each.");
		Scanner sin=new Scanner(System.in);
		String x= sin.nextLine();
		String[] keyword=x.split(" ");
		sin.close();
		
		int totalkeywords=0; int filecount=0; int comp=0;
		for(String d: keyword)
		{   System.out.print(d);
			totalkeywords++;
		}
		
		//----------------------------------Define Keywords above----------------------------------//
		
		String directory="F:/CVs";
		File dir = new File(directory);
		File[] fileslist = dir.listFiles(new FileFilterer());
	    
		FileWriter foutput=new FileWriter("F:/CV_Ranker.doc");
		//output text file
		
		foutput.write("Total no. of keywords : "+totalkeywords);
		t3.append("Total no. of keywords : "+totalkeywords);
		
		for (File f : fileslist)
	    {
	   //------------------------------------------doc---------------------------------------------//
	      if(f.getName().endsWith(".doc")) 
	      {   filecount++;
	          WordExtractor extractor = null;
	          try
	          {   System.out.println("Opening CV : "+f.getName()+"(word format)\n");
	              foutput.write("\nOpening CV : "+f.getName()+"(word format)\n");
	              int count=0;
	          
	              FileInputStream fis = new FileInputStream(f.getAbsolutePath());
	              HWPFDocument document = new HWPFDocument(fis); 
	              extractor = new WordExtractor(document);
	              String[] fileData = extractor.getParagraphText(); 
	 
	                  	  String lines[] = fileData;
		                  for (String line : lines) 
		                  {      
		         		     String check[] = {}; 
		         	         check=line.split(" ");  
		         	          for (String word : check) 
		         	          {
		         	                 for(String k:keyword) 
		         	                 {	 
		         	        	        if (word.equals(k))  
		         	                    {
		         	        	    	  System.out.print("Keyword '"+k+"' is found!\n");
		         	        	    	  foutput.write("Keyword '"+k+"' is found!\n");
		         	                      count++;    
		         	                     
		         	                    }
		         	                 }
		         	          }
		         	         }
	                
	              t3.append("Total number of keywords found in "+f.getName()+" : "+count+"\n");
	              foutput.write("Total number of keywords found in "+f.getName()+" : "+count+"\n");
	              if(count>comp) comp=count;
	              
	                  
	          }
	          catch (Exception exep)
	          {
	              exep.printStackTrace();
	          }  
	      }	 
	     //------------------------------------else for pdf---------------------------------------//
	      else if(f.getName().endsWith(".pdf"))
	      {   filecount++;
	    	  try (PDDocument document = PDDocument.load(f)) 
	          {   System.out.println("\nOpening CV : "+f.getName()+"(pdf format)\n");
	              foutput.write("\nOpening CV : "+f.getName()+"(pdf format)\n");
	            	int count=0;
	          	
	              document.getClass();

	              if (!document.isEncrypted()) 
	              {
	                  PDFTextStripperByArea stripper = new PDFTextStripperByArea(); 
	                  stripper.setSortByPosition(true);

	                  PDFTextStripper tStripper = new PDFTextStripper();

	                  String pdfFileInText = tStripper.getText(document);

	  				
	                  String lines[] = pdfFileInText.split("\\r?\\n");
	                  for (String line : lines) 
	                  {      
	         		     String check[] = {}; 
	         	         check=line.split(" ");  
	         	          for (String word : check) 
	         	          {
	         	                 for(String k:keyword)
	         	                 {	 
	         	        	        if (word.equals(k))  
	         	                    {
	         	        	    	  System.out.print("Keyword '"+k+"' is found!\n");  
	         	        	    	  foutput.write("Keyword '"+k+"' is found!\n");
	         	                      count++;   
	         	                     
	         	                    }
	         	                 }
	         	          }
	         	         }  	
	                 }
	              System.out.println("Total keywords found / CV strength = "+count+"\n");
	              foutput.write("Total number of keywords found in "+f.getName()+" : "+count+"\n");
	              if(count>comp) 
	              comp=count; 

	              }
	      }
	      else
	      System.out.print("No doc/pdf files found in the specified directory");	
	    }	
		foutput.write("\nTotal number of files scanned : "+filecount);
		foutput.write("\nHighest number of keywords found in a CV : "+comp);
	
		foutput.close();
		
	
		
//------------------------------------------------------------------------------------------------------------		
		String bestCVname = null;
		
		
		for (File t : fileslist)
	    {
	   //------------------------------------------doc---------------------------------------------//
	      if(t.getName().endsWith(".doc")) 
	      {   filecount++;
	          WordExtractor extractor = null;
	          try
	          {   
	              int count=0;
	          
	              FileInputStream fis = new FileInputStream(t.getAbsolutePath());
	              HWPFDocument document = new HWPFDocument(fis); 
	              extractor = new WordExtractor(document);
	              String[] fileData = extractor.getParagraphText(); 
	 
	                  	  String lines[] = fileData;
		                  for (String line : lines) 
		                  {      
		         		     String check[] = {}; 
		         	         check=line.split(" ");  
		         	          for (String word : check) 
		         	          {
		         	                 for(String k:keyword) 
		         	                 {	 
		         	        	        if (word.equals(k))   
		         	                    {
		         	                      count++;     
		         	                    }
		         	                 }
		         	          }
		         	         if(comp==count) 
				             bestCVname=t.getName(); 
		         	         }
	                  
		                  t3.append("Highest ranked CV filtered among all based on maximum keywords : "+bestCVname);
			  	  		  foutput.write("\nBest/Highest Ranked CV filtered among selected CVs : "+bestCVname);
	          }
	          catch (Exception exep)
	          {
	              exep.printStackTrace();
	          }  
	          
	      }	 
	     //------------------------------------else for pdf---------------------------------------//
	      else if(t.getName().endsWith(".pdf"))
	      {   filecount++;
	    	  try (PDDocument document = PDDocument.load(t)) 
	          {   
	            	int count=0;
	          	
	              document.getClass();

	              if (!document.isEncrypted()) 
	              {
	                  PDFTextStripperByArea stripper = new PDFTextStripperByArea(); 
	                  stripper.setSortByPosition(true);

	                  PDFTextStripper tStripper = new PDFTextStripper();

	                  String pdfFileInText = tStripper.getText(document);

	  				
	                  String lines[] = pdfFileInText.split("\\r?\\n");
	                  for (String line : lines) 
	                  {      
	         		     String check[] = {}; 
	         	         check=line.split(" ");  
	         	          for (String word : check) 
	         	          {
	         	                 for(String k:keyword) 
	         	                 {	 
	         	        	        if (word.equals(k))   
	         	                    {
	         	                      count++;     
	         	                    }
	         	                 }
	         	          }
	         	         if(comp==count) 
	                         bestCVname=t.getName();
	         	         }      	
	                 }
	              
	              t3.append("Highest ranked CV filtered among all based on maximum keywords : "+bestCVname);
	  	  		  foutput.write("\nBest/Highest Ranked CV filtered among selected CVs : "+bestCVname);
	              }
	      }	
	    }	
		
		foutput.close();	
    }
		
    }
    



 
 */ 